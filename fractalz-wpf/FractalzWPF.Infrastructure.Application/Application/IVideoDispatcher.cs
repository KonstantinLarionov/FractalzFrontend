using System.Collections.Generic;
using System.Drawing;
using FractalzWPF.Application.Domains.Entities.Conference;

namespace FractalzWPF.Infrastructure.Application.Application
{
    public interface IVideoDispatcher
    {
        public delegate void GetCapture(byte[] capture);
        public event GetCapture GetCaptureEvent;
        public List<VideoDevice> GetListDevices();
        public void StartVideoStream(VideoDevice device);
        public void StopVideoStream(VideoDevice device);
    }
}