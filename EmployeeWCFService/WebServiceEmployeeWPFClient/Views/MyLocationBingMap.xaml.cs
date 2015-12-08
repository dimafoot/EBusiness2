using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl.WPF;

namespace WebServiceEmployeeWPFClient.Views
{
    /// <summary>
    /// Logique d'interaction pour MyLocationBingMap.xaml
    /// </summary>
    public partial class MyLocationBingMap : Window
    {
        public MyLocationBingMap()
        {
            InitializeComponent();
            myMap.Focus();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                GetMyLocation();
            }
            catch (SystemException err)
            {
                string errMsg = "Unable to get your location: " + err.Message.ToString();
                MessageBox.Show(errMsg);
            }
        }

        private void GetMyLocation()
        {
            string _urlResponse = "";
            string _ipinfodb_apikey = "As9THYf7LjK_dLhUhKrO6OcsGTK5H_PH0MCwgvWAn9Fr1IYAQBHSRMfjX1FptgLT";
            string _mypublicipaddress = GetPublicIpAddress();
            string _urlRequest = "http://api.ipinfodb.com/v3/ip-city/?key=" + _ipinfodb_apikey + "&" + _mypublicipaddress;

            var request = (HttpWebRequest)WebRequest.Create(_urlRequest);

            request.UserAgent = "curl"; // this simulate curl linux command

            request.Method = "GET";
            using (WebResponse response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    _urlResponse = reader.ReadToEnd();
                }
            }

            string[] _myGeocodeInfo = _urlResponse.Split(';');

            Location myLoc = new Location(Convert.ToDouble(_myGeocodeInfo[8]), Convert.ToDouble(_myGeocodeInfo[9]));
            myMap.SetView(myLoc, Convert.ToDouble(14), Convert.ToDouble(0));

            Pushpin myPin = new Pushpin();
            MapLayer.SetPosition(myPin, myLoc);
            myMap.Children.Add(myPin);

            System.Windows.Controls.Label label = new System.Windows.Controls.Label();
            label.Content = "Here I AM!";
            label.Foreground = new SolidColorBrush(Colors.DarkBlue);
            label.Background = new SolidColorBrush(Colors.WhiteSmoke);
            label.FontSize = 30;
            MapLayer.SetPosition(label, myLoc);
            myMap.Children.Add(label);
        }

        private string GetPublicIpAddress()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://ifconfig.me");

            request.UserAgent = "curl"; //simulate the linux curl command: its "cleaner"

            string publicIPAddress;

            request.Method = "GET";
            using (WebResponse response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    publicIPAddress = reader.ReadToEnd();
                }
            }

            return publicIPAddress.Replace("\n", "");
        }

        private void ButtonBase_OnClick_2(object sender, RoutedEventArgs e)
        {
            myMap.ZoomLevel -= 1;
        }
        private void ButtonBase_OnClick_3(object sender, RoutedEventArgs e)
        {
            myMap.ZoomLevel += 1;
        }

    }
}
