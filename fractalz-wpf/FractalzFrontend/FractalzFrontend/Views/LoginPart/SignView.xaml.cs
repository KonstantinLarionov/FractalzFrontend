using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FractalzFrontend.Models.LoginPart;
using FractalzFrontend.ViewModels.LoginPart;
using Newtonsoft.Json;

namespace FractalzFrontend.Views.LoginPart
{
    /// <summary>
    /// Логика взаимодействия для SignView.xaml
    /// </summary>
    public partial class SignView : UserControl
    {
        private readonly MainWindow main;
        private readonly SignLoginVM _vm = new SignLoginVM();
        private readonly SignLoginModel _model;

        public SignView(MainWindow main)
        {
            InitializeComponent();
            _model = new SignLoginModel(_vm);
            DataContext = _vm;
            this.main = main;
        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e) => main.SwtichSpace(0);

        private void FromPc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UIElement_OnDragEnter(object sender, DragEventArgs e)
        {
            Mouse.SetCursor(Cursors.Hand);
            e.Handled = true;
        }

        private void UIElement_OnDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                using (StreamReader r = new StreamReader(files[0]))
                {
                    string json = r.ReadToEnd();
                    UserData items = JsonConvert.DeserializeObject<UserData>(json);
                    var log = _model.SignLoginRequest(items.Login, items.Password);
                    if (log.Success)
                    { 
                        main.Visibility = Visibility.Collapsed;
                        new Layout(main).Show();
                    }
                    else
                        MessageBox.Show(log.Message);
                }
                
            }
        }
    }

    public class UserData
    {
        [JsonProperty("OrganizationName")]
        public string OrganizationName { get; set; }

        [JsonProperty("Login")]
        public string Login { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("Server")]
        public string Server { get; set; }

        [JsonProperty("Port")]
        public string Port { get; set; }

        [JsonProperty("Proxy")]
        public string Proxy { get; set; }

    }
}
