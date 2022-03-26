using FractalzWPF.Application.Domains.Entities.Chat;
using FractalzWPF.Application.Domains.Entities.Profile;

namespace FractalzWPF.Infrastructure.Application.Application
{
    public interface ILinkedEventService
    {
        public delegate void GetVideo(byte[] message);

        public event GetVideo GetVideoEvent;
        public delegate void GetMessage(Message message);

        public event GetMessage GetMessageEvent;

        public delegate void UserUpdateStatus(User user);

        public event UserUpdateStatus UserUpdateStatusEvent;

        public delegate void DialogUpdate(Dialog dialog);

        public event DialogUpdate DialogUpdateEvent;

        public void ConnectDefaultEvent();
        public void SendBytes(byte[] arr);
        public void ConnectConference(int conferenceId);
        public void SendUDPPack(byte[] array);
    }
}