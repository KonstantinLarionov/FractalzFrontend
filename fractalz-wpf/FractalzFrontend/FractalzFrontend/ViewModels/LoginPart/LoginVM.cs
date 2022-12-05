using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.ViewModels.LoginPart
{
    public class LoginVM : INotifyPropertyChanged
    {
        private string login;
        private string password;

        public string Login { get => login; set { login = value; OnPropertyChanged(nameof(Login)); } }
        public string Password { get => password; set { password = value; OnPropertyChanged(nameof(Password)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
