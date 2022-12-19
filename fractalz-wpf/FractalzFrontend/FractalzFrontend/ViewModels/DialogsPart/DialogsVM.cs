using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Fractalz.Application.Domains.MappingEntities.Chat;
using FractalzFrontend.Annotations;

namespace FractalzFrontend.ViewModels.DialogsPart
{
    public class DialogsVM:INotifyPropertyChanged
    {
        private string userName { get; set; }
        
        private string foundDialogName { get; set; }
        private string foundDialogLastMessage { get; set; }
        private Guid foundDialogId { get; set; }
        public string UserName { get => userName; set { userName = value; OnPropertyChanged(nameof(UserName)); } }
        public string FoundDialogName { get => foundDialogName; set { foundDialogName = value; OnPropertyChanged(nameof(FoundDialogName)); } }
        public Guid FoundDialogId { get => foundDialogId; set { foundDialogId = value; OnPropertyChanged(nameof(FoundDialogId)); } }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}