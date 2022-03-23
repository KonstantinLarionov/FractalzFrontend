using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;
using FractalzWPF.Application.Domains.Entities.Conference;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Events;

namespace FractalzWPF.Infrastructure.Video;

public class VideoDispatcher : IVideoDispatcher
{
    public event IVideoDispatcher.GetCapture? GetCaptureEvent;
    VideoCaptureDevice _device;
    private FilterInfoCollection _cd;

    public VideoDispatcher()
    {
       
    }

    public List<VideoDevice> GetListDevices()
    {
        var _cd = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        List<VideoDevice> videoDevices = new List<VideoDevice>();
        foreach (FilterInfo VARIABLE in _cd)
        {
            videoDevices.Add(new VideoDevice(){Name = VARIABLE.MonikerString});
        }

        return videoDevices;
    }

    public void StartVideoStream(VideoDevice device)
    {
        var filter = new FilterInfo(device.Name);            
        _device = new VideoCaptureDevice(filter.MonikerString);
        _device.NewFrame += device_NewFrame;
        _device.Start();
    }
    
    public void StopVideoStream(VideoDevice device)
    {
        if (_device == null) return;
 
        _device.NewFrame -= device_NewFrame;
        _device.SignalToStop();
    }
    
    private void device_NewFrame(object sender, NewFrameEventArgs e)
    {
        Bitmap bmp = e.Frame;
        using (MemoryStream memory = new MemoryStream())
        {
            bmp.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
            GetCaptureEvent?.Invoke(memory.ToArray());

        }
        
    }
}