﻿using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1907A.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomerPage : Page
    {
      
        public CustomerPage()
        {
            this.InitializeComponent();
        }

        private void ListViewLoaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            customers.Add(new Customer("quang1", "1234", 13, new DateTime()));
            customers.Add(new Customer("quang2", "1234", 13, new DateTime()));
            customers.Add(new Customer("quang3", "1234", 13, new DateTime()));
            LV.ItemsSource = customers;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer(FullName.Text, Telephone.Text,
                Convert.ToInt32(Age.Text), Birthday.Date.DateTime);
         
            //LV.Items.Add(c.ToString());
            LV.Items.Add(c);
        }

    }
}
