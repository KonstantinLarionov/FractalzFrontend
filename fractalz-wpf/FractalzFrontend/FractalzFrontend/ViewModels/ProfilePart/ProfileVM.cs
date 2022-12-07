using System;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace FractalzFrontend.ViewModels.ProfilePart
{
    public class ProfileVM:INotifyPropertyChanged
    {
        private string name;
        private string adress;
        private string number;
        private string email;
        private MultipartFormDataContent logo;
        private MultipartFormDataContent background;
        private string vkLink;
        private string tgLink;
        private string login;
        private Guid id;
        public Guid Id { get => id; set { id = value; OnPropertyChanged(nameof(Id)); }}
        public string Email { get => email; set { email = value; OnPropertyChanged(nameof(Email)); }}
        public string Login { get => login; set { login = value; OnPropertyChanged(nameof(Login)); }}
        public string Name { get => name; set { name = value; OnPropertyChanged(nameof(Name)); } }
        public string Adress { get => adress; set { adress = value; OnPropertyChanged(nameof(Adress)); } }
        public string Number { get => number; set { number = value; OnPropertyChanged(nameof(Number)); } }
        public MultipartFormDataContent Logo { get => logo; set { logo = value; OnPropertyChanged(nameof(Logo)); } }
        public MultipartFormDataContent Background { get => background; set { background = value; OnPropertyChanged(nameof(Background)); } }
        public string VkLink { get => vkLink; set { vkLink = value; OnPropertyChanged(nameof(VkLink)); } }
        public string TgLink { get => tgLink; set { tgLink = value; OnPropertyChanged(nameof(TgLink)); } }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}