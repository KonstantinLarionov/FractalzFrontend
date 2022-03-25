using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using FractalzWPF.Application.Domains.Entities.Conference;
using FractalzWPF.Infrastructure.Application.Application;

namespace FractalzWPF.Infrastructure.Vizualizer.Windows
{
    public partial class ConferenceWindow : Window
    {
        private readonly ILinkedEventService _linkedEventService;
        private readonly INavigatorHandlers _handlers;
        private readonly IVideoDispatcher _videoDispatcher;
        private readonly List<VideoDevice> list;
        public int ConferenceId { get; set; } = 1;

        public ConferenceWindow(ILinkedEventService linkedEventService, INavigatorHandlers handlers, IVideoDispatcher videoDispatcher)
        {
            InitializeComponent();
            
            _linkedEventService = linkedEventService;
            _linkedEventService.GetVideoEvent += LinkedEventServiceOnGetVideoEvent;
            _handlers = handlers;
            _videoDispatcher = videoDispatcher;
            list = _videoDispatcher.GetListDevices();
            _videoDispatcher.GetCaptureEvent += VideoDispatcherOnGetCaptureEvent;
            _videoDispatcher.StartVideoStream(list[0]);
        }

        private void LinkedEventServiceOnGetVideoEvent(byte[] message)
        {
            Dispatcher.BeginInvoke((Action) delegate
            {
                var img = LoadImage(message);
                if(img !=null)
                    videoServer1.Source = img;
            });

        }

        private void VideoDispatcherOnGetCaptureEvent(byte[] capture)
        {
            Dispatcher.BeginInvoke((Action) delegate
            {
                myVideo.Source = LoadImage(capture);
            });
            Task.Run(() => _linkedEventService.SendBytes(capture));
            
        }
        public static ImageSource ByteToImage(byte[] imageData)
        {
            BitmapImage biImg = new BitmapImage();
            MemoryStream ms = new MemoryStream(imageData);
            biImg.BeginInit();
            biImg.StreamSource = ms;
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
        private void ConferenceWindow_OnLoaded(object sender, RoutedEventArgs e) =>
            _linkedEventService.ConnectConference(ConferenceId);

        private void ConferenceWindow_OnUnloaded(object sender, RoutedEventArgs e)
        {
            _linkedEventService.GetVideoEvent -= LinkedEventServiceOnGetVideoEvent;
            _videoDispatcher.GetCaptureEvent -= VideoDispatcherOnGetCaptureEvent;

            _videoDispatcher.StopVideoStream(list[0]);
        }
    }
    
}