using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace MIO.Pages
{
    public partial class HomePage : PhoneApplicationPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void NavigateToInnerPage(string pageName)
        {
            if (!string.IsNullOrEmpty(pageName))
            {
                string format = "/{0}/{1}";
                string uri = string.Format(format, Util.Constants.PagesNamespaceName, pageName);
                NavigationService.Navigate(new Uri(uri, UriKind.RelativeOrAbsolute));
            }
        }

        private void btnMainRoutes_Click(object sender, RoutedEventArgs e)
        {
            NavigateToInnerPage("MainRoutes.xaml");
        }

        private void btnAdditionalRoutes_Click(object sender, RoutedEventArgs e)
        {
            NavigateToInnerPage("AdditionalRoutes.xaml");
        }

        private void btnNearbyStations_Click(object sender, RoutedEventArgs e)
        {
            NavigateToInnerPage("NearbyStations.xaml");
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            NavigateToInnerPage("About.xaml");
        }
    }
}