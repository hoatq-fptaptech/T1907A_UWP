using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T1907A.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1907A.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitViewDemo : Page
    {
        public static Frame contentFrame;

        public SplitViewDemo()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SV.IsPaneOpen = !SV.IsPaneOpen;
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E80F",16)), "List Contact","lst"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("EA4A", 16)), "Add Contact","add"));
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)LV.SelectedItem;
            if (selected.Dest.Equals("lst"))
            {
                FrContent.Navigate(typeof(ContactList));
            }else if (selected.Dest.Equals("add"))
            {
                FrContent.Navigate(typeof(AddContact));
            }
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame = FrContent;
            FrContent.Navigate(typeof(ContactList));
        }
    }
}
