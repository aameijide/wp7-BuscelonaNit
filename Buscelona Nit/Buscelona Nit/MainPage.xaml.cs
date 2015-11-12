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

namespace Buscelona_Nit
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        void OnN0ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N0.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN1ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N1.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN2ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N2.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN3ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N3.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN4ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N4.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN5ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N5.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN6ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N6.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN7ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N7.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN8ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N8.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN9ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N9.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnN11ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/N11.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }
    }
}