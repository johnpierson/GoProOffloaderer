using System;
using System.Collections.Generic;
using System.ComponentModel;
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

using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Media.MediaProperties;
using Windows.Storage.Streams;

namespace GoProOffloaderer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public class GDeviceInformation
        {
            public GDeviceInformation(DeviceInformation inDeviceInformation, bool inPresent, bool inConnected)
            {
                DeviceInfo = inDeviceInformation;
                IsPresent = inPresent;
                IsConnected = inConnected;
            }
            public DeviceInformation DeviceInfo { get; set; } = null;
            public bool IsPresent { get; set; } = false;
            public bool IsConnected { get; set; } = false;
            public bool IsVisible { get { return IsPresent || IsConnected; } }

            private GDeviceInformation() { }
        }


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
