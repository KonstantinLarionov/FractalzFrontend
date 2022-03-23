using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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
        public int ConferenceId { get; set; } = 0;

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
                videoServer1.Source = LoadImage(message);
            });
        }

        private void VideoDispatcherOnGetCaptureEvent(byte[] capture)
        {
            //_linkedEventService.SendBytes(capture);
            Dispatcher.BeginInvoke((Action) delegate
            {
                myVideo.Source = LoadImage(capture);
            });
            Dispatcher.BeginInvoke((Action) delegate
            {
                videoServer1.Source = LoadImage(capture);
            });
            Dispatcher.BeginInvoke((Action) delegate
            {
                videoServer2.Source = LoadImage(capture);
            });
            Dispatcher.BeginInvoke((Action) delegate
            {
                videoServer3.Source = LoadImage(capture);
            });
            Dispatcher.BeginInvoke((Action) delegate
            {
                videoServer4.Source = LoadImage(capture);
            });
            Dispatcher.BeginInvoke((Action) delegate
            {
                myVideoMain.Source = LoadImage(capture);
            });
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
        private void ConferenceWindow_OnLoaded(object sender, RoutedEventArgs e) =>
            _linkedEventService.ConnectConference(ConferenceId);

        private void ConferenceWindow_OnUnloaded(object sender, RoutedEventArgs e)
        {
            _videoDispatcher.StopVideoStream(list[0]);
        }
    }
    
}