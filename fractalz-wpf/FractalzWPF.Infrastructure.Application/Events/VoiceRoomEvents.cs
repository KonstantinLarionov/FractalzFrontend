using System.Windows.Controls;

namespace FractalzWPF.Infrastructure.Application.Events
{
    public class VoiceRoomEvents
    {
        public delegate void DeleteDelegate(TreeViewItem task);
        public static event DeleteDelegate DeleteEvent;
        public static void DeleteEventInvoke(TreeViewItem task) => DeleteEvent?.Invoke(task);

        public delegate void CreateDelegate(TreeViewItem task);
        public static event CreateDelegate CreateEvent;
        public static void CreateEventInvoke(TreeViewItem task) => CreateEvent?.Invoke(task);

        public delegate void ConnectDelegate(TreeViewItem task);
        public static event ConnectDelegate ConnectEvent;
        public static void ConnectEventInvoke(TreeViewItem task) => ConnectEvent?.Invoke(task);
        
        public delegate void DisconnectDelegate(TreeViewItem task);
        public static event DisconnectDelegate DisconnectEvent;
        public static void DisconnectEventInvoke(TreeViewItem task) => DisconnectEvent?.Invoke(task);
    }
}