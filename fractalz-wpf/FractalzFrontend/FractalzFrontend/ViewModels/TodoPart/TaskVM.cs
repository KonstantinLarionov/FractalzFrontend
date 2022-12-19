using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.ViewModels.TodoPart
{
    public class TaskVM
    {
        public string Id;
        private string header;
        private string description;
        private bool isDone;
        private string time;
        private DateTime Datetime { get; set; }

        public string Header { get => header; set { header = value; OnPropertyChanged(nameof(Header)); } }
        public string Description { get => description; set { description = value; OnPropertyChanged(nameof(Description)); } }
        public bool IsDone { get => isDone; set { isDone = value; OnPropertyChanged(nameof(IsDone)); } }
        public string Time { get => Datetime.ToShortTimeString(); } // set { time = value; OnPropertyChanged(nameof(Time));

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
