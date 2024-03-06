using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Comanda.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Browser.WidthRequest = 1000;
            Browser.HeightRequest = 1000;
            Browser.Source = "http://192.168.56.1/";
        }

        private void Browser_Navigating(object sender, WebNavigatingEventArgs e)
        {

        }

        private void Browser_Navigated(object sender, WebNavigatedEventArgs e)
        {

        }
    }
}
