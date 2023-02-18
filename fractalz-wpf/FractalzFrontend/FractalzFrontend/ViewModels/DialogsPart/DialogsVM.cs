using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FractalzFrontend.ViewModels.DialogsPart
{
    public class DialogsVM:INotifyPropertyChanged
    {
        private string userName { get; set; }
        private string foundDialogName { get; set; }
        private string foundDialogLastMessage { get; set; }
        private Guid foundDialogId { get; set; }
        public ObservableCollection<DialogVM> Dialogs { get; set; }  = new ObservableCollection<DialogVM>();
        public string UserName { get => userName; set { userName = value; OnPropertyChanged(nameof(UserName)); } }
        public string FoundDialogName { get => foundDialogName; set { foundDialogName = value; OnPropertyChanged(nameof(FoundDialogName)); } }
        public Guid FoundDialogId { get => foundDialogId; set { foundDialogId = value; OnPropertyChanged(nameof(FoundDialogId)); } }
        public event PropertyChangedEventHandler PropertyChanged;

        public void AddValue(DialogVM value)
        {
            var itemFinder = Dialogs.FirstOrDefault(x=>x.Id == value.Id);
            if (itemFinder != null)
                Dialogs.Insert(Dialogs.IndexOf(itemFinder), value);
            else
                Dialogs.Add(value);
            OnPropertyChanged(nameof(Dialogs));
        }
        public void RemoveValue(int index)
        {
            Dialogs.RemoveAt(index);
            OnPropertyChanged(nameof(Dialogs));
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}