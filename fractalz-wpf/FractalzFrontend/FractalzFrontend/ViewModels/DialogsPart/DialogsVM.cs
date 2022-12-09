using System.ComponentModel;
using System.Runtime.CompilerServices;
using Fractalz.Application.Domains.MappingEntities.Chat;
using FractalzFrontend.Annotations;

namespace FractalzFrontend.ViewModels.DialogsPart
{
    public class DialogsVM:INotifyPropertyChanged
    {
        private string userName { get; set; }
        public string UserName { get => userName; set { userName = value; OnPropertyChanged(nameof(UserName)); } }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}