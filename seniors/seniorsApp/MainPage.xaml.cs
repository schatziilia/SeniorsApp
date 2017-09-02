using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace seniorsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Stack<Uri> _history = new Stack<Uri>();
        private Uri _current = null;


        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        public void sos_function(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(sosPage));
        }

        public void info_function(object sender, RoutedEventArgs e)
        {
            infoClass info = new infoClass();
            this.Frame.Navigate(typeof(infoPage));
        }
       

        public void phone_function(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(phonePage));
        }

        public void pill_function(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pillPage));
        }


        public void options_function(object sender, RoutedEventArgs e)
        {
            infoClass info = new infoClass();
            this.Frame.Navigate(typeof(BasicPage1));
        }
       



        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }


       


    }
}