using System.Windows.Controls;

namespace FractalzWPF.Infrastructure.Application.Events
{
    public class VoiceEvents
    {
        public delegate void DeleteDelegate(UserControl task);
        public static event DeleteDelegate DeleteEvent;
        public static void DeleteEventInvoke(UserControl task) => DeleteEvent?.Invoke(task);

        public delegate void CreateDelegate(UserControl task);
        public static event CreateDelegate CreateEvent;
        public static void CreateEventInvoke(UserControl task) => CreateEvent?.Invoke(task);
    }
}