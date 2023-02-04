using Fractalz.Application.Domains.Entities.Todo;

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
        private string todoDate = DateTime.Now.ToString("d");
        private bool isNotDone = false;

        public string TodoDate { get => todoDate; set
            { todoDate = value; OnPropertyChanged(nameof(TodoDate)); } }
        public bool IsNotDone { get => isNotDone; set { isNotDone = value; OnPropertyChanged(nameof(isNotDone)); } }
        public ObservableCollection<TaskVM> Tasks { get; set; } = new ObservableCollection<TaskVM>();
        public ObservableCollection<TaskVM> BufferTasks { get; set; } = new ObservableCollection<TaskVM>();

        public void AddValue(TaskVM value)
        {
            var itemFinder = Tasks.FirstOrDefault(x => x.Datetime < value.Datetime);
            if(itemFinder != null)
                Tasks.Insert(Tasks.IndexOf(itemFinder), value);
            else
                Tasks.Add(value);
            OnPropertyChanged(nameof(Tasks));
        }
        public void RemoveValue(int index)
        {
            Tasks.RemoveAt(index);
            OnPropertyChanged(nameof(Tasks));
        }
        public void AddFiltred(ObservableCollection<TaskVM> tasks)
        {
            Tasks = tasks;
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
