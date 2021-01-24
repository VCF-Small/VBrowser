using System;
using System.Diagnostics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VBrowser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            WebView Web = (WebView)FindName("Web");
            Uri Url = new Uri("https://www.google.com");
            Web.Navigate(Url);
        }

        private void Search_Web(object sender, RoutedEventArgs e)
        {
            TextBox UrlBox = (TextBox)FindName("Urlbox");
            if (UrlBox.Text.StartsWith("https://") || UrlBox.Text.StartsWith("http://") )
            {
                Uri Url = new Uri(UrlBox.Text);
                Web.Navigate(Url);
            }
            else
            {
                int i;
                String url ="https://www.google.com/search?q=";
                for(i =0; i<UrlBox.Text.Length; i++)
                {
                    if(UrlBox.Text[i] == ' ')
                    {
                        url += "%20";
                    }
                    url += UrlBox.Text[i];
                }
                Uri Url = new Uri(url);
                Web.Navigate(Url);
            }
            

        }
    }
}
