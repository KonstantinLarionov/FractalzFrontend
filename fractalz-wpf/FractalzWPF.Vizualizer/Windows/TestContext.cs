using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using FractalzWPF.Infrastructure.Vizualizer.Annotations;

namespace FractalzWPF.Infrastructure.Vizualizer.Windows
{
    public class TestContext: INotifyPropertyChanged
    {
        private ImageSource _yourImage;

        public ImageSource YourImage
        {
            get { return _yourImage; }
            set 
            { 
                _yourImage = value;
                RaisePropertyChanged(nameof(YourImage));
            }
        }
        private ImageSource _VideoServer;

        public ImageSource VideoServer
        {
            get { return _VideoServer; }
            set 
            { 
                _VideoServer = value;
                RaisePropertyChanged(nameof(VideoServer));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}