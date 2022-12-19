using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.ViewModels.TodoPart
{
    public class TodoVM : INotifyPropertyChanged
    {
        public ObservableCollection<TaskVM> Tasks { get; set; } = new ObservableCollection<TaskVM> { new TaskVM() { Description = "asdasd", Header = "asdasdasd", IsDone = false, Datetime = DateTime.Now } };

        public void AddValue(TaskVM value)
        {
            Tasks.Add(value);
            OnPropertyChanged(nameof(Tasks));
        }
        public void RemoveValue(int index)
        {
            Tasks.RemoveAt(index);
            OnPropertyChanged(nameof(Tasks));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
