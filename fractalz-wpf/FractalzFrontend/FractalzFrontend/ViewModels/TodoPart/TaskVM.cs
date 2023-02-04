using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FractalzFrontend.ViewModels.TodoPart
{
    public class TaskVM : INotifyPropertyChanged
    {
        public TodoVM todoVM;
        public string id;
        public bool IsNotDone;
        private string header;
        private string description;
        private bool isDone;
        private string time;
        private DateTime datetime;
        private Visibility visibility;

        public Visibility Visibility { get => visibility; set { visibility = value; OnPropertyChanged(nameof(Visibility)); } }
        public DateTime Datetime { get => datetime; set { datetime = value; OnPropertyChanged(nameof(Datetime)); } }

        public string Header { get => header; set { header = value; OnPropertyChanged(nameof(Header)); } }
        public string Description { get => description; set { description = value; OnPropertyChanged(nameof(Description)); } }
        public string Id { get => id; set { id = value; OnPropertyChanged(nameof(id)); } }
        public bool IsDone { get => isDone; set { isDone = value; OnPropertyChanged(nameof(IsDone)); } }
        public string Time { 
            get => Datetime.ToShortTimeString(); 
            set { time = value; OnPropertyChanged(nameof(Time)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
