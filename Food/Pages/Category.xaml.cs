﻿using Food.Models;
using Food.Services;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Category : Page
    {
        private CategoryService _categoryService = new CategoryService();
        public Category()
        {
            this.InitializeComponent();
        }

        private MenuItem CatDetail { get; set; }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            MenuItem menuItem = e.Parameter as MenuItem;
            CatDetail = menuItem;
            Models.CategoryDetail catDetail = await _categoryService.CategoryDetail(CatDetail.id);
            ProductList.ItemsSource = catDetail.data.foods;
        }
    }
}
