using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.ViewModels.LoginPart
{
    public class RegistrationVM
    {
        private string email;
        private string code;
        private string login;
        private string password;

        public string Email { get => email; set { email = value; OnPropertyChanged(nameof(Email)); } }
        public string Code { get => code; set { code = value; OnPropertyChanged(nameof(Code)); } }
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
