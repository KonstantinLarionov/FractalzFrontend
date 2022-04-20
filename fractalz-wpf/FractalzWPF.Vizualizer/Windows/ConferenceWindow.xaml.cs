using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using FractalzWPF.Application.Domains.Entities.Conference;
using FractalzWPF.Infrastructure.Application.Application;
using Rtsp;
using Rtsp.Messages;

namespace FractalzWPF.Infrastructure.Vizualizer.Windows
{
    public partial class ConferenceWindow : Window
    {
        private readonly ILinkedEventService _linkedEventService;
        private readonly INavigatorHandlers _handlers;
        private readonly IVideoDispatcher _videoDispatcher;
        private readonly List<VideoDevice> list;
        private TestContext test;
        private readonly RtspListener listner;

        public int ConferenceId { get; set; } = 1;
        

        public ConferenceWindow(ILinkedEventService linkedEventService, INavigatorHandlers handlers, IVideoDispatcher videoDispatcher)
        {
            InitializeComponent();
            test = new TestContext();
            this.DataContext = test;
            
            _linkedEventService = linkedEventService;
            _handlers = handlers;
            _videoDispatcher = videoDispatcher;
            list = _videoDispatcher.GetListDevices();
            _videoDispatcher.GetCaptureEvent += VideoDispatcherOnGetCaptureEvent;
            listner = new RtspListener(new RtspTcpTransport("127.0.0.1",7711));
            listner.MessageReceived += ListnerOnMessageReceived;
            listner.DataReceived += ListnerOnDataReceived;
            listner.Start();

        }

        private void ListnerOnDataReceived(object? sender, RtspChunkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ListnerOnMessageReceived(object? sender, RtspChunkEventArgs e)
        {
            throw new NotImplementedException();
        }


        private void VideoDispatcherOnGetCaptureEvent(byte[] capture)
        {
            //2764854 65535
            test.YourImage = LoadImage(capture);

            byte[] arr = new byte[1] {233};
            listner.SendData(1,arr);
        }
        public static ImageSource ByteToImage(byte[]? imageData)
        {
            BitmapImage biImg = new BitmapImage();
            if (imageData != null)
            {
                MemoryStream ms = new MemoryStream(imageData);
                biImg.BeginInit();
                biImg.StreamSource = ms;
            }

            biImg.EndInit();
            ImageSource imgSrc = biImg as ImageSource;
            return imgSrc;
        }
        private static BitmapImage LoadImage(byte[] imageData)
        {
            try
            {
                if (imageData == null || imageData.Length == 0) return null;
                var image = new BitmapImage();
                using (var mem = new MemoryStream(imageData))
                {
                    mem.Position = 0;
                    image.BeginInit();
                    image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.UriSource = null;
                    image.StreamSource = mem;
                    image.EndInit();
                }

                image.Freeze();
                
                return image;
            }
            catch
            {
                return null;
            }
        }

        private void ConferenceWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _linkedEventService.ConnectConference(ConferenceId);
            _videoDispatcher.StartVideoStream(list[0]);
        }

        private void ConferenceWindow_OnUnloaded(object sender, RoutedEventArgs e)
        {
            _videoDispatcher.GetCaptureEvent -= VideoDispatcherOnGetCaptureEvent;

            _videoDispatcher.StopVideoStream(list[0]);
        }
    }
    
}