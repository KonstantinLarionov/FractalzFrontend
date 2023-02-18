using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FractalzFrontend.ViewModels.DialogsPart
{
    public class DialogVM : INotifyPropertyChanged
    {
        private bool isP2P;
        private string dateTimeLastMessage;
        private string lastMessage;
        private string account;
        private Guid id;
        private SolidColorBrush onlineStatus;

        public DateTime DateTime;
        public bool IsRead;
        private SolidColorBrush lastMessageStatus;

        public Guid Id { get => id; set { id = value; OnPropertyChanged(nameof(Id)); } }
        public string Account { get => account; set { account = value; OnPropertyChanged(nameof(Account)); } }
        public string LastMessage
        {
            get => lastMessage.Length > 54 ? new string(lastMessage.Take(54).ToArray()) + "..." : lastMessage;
            set { lastMessage = value; OnPropertyChanged(nameof(LastMessage)); }
        }
        public string DateTimeLastMessage { get => DateTime.ToShortTimeString(); set { dateTimeLastMessage = value; OnPropertyChanged(nameof(DateTimeLastMessage)); } }
        public bool IsP2P { get => isP2P; set { isP2P = value; OnPropertyChanged(nameof(IsP2P)); } }
        public SolidColorBrush OnlineStatus { get => onlineStatus; set { onlineStatus = value; OnPropertyChanged(nameof(OnlineStatus)); } }
        public SolidColorBrush LastMessageStatus 
        {
            get 
            {
                if (IsRead)
                    return (SolidColorBrush)new BrushConverter().ConvertFrom("#FF8C8C8C");
                else
                    return new SolidColorBrush(Colors.Black);
            }
            set { lastMessageStatus = value; OnPropertyChanged(nameof(LastMessageStatus)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
