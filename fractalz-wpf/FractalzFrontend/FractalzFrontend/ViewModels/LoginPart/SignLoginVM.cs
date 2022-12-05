using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FractalzFrontend.ViewModels.LoginPart
{
    public class SignLoginVM
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