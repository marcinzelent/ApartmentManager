﻿using System;
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
using ApartmentManager.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ApartmentManager.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ApartmentDefectPage : Page
    {
        public ApartmentDefectPage()
        {
            this.InitializeComponent();
            
        }
        private void NavigateNewDefect(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ApartmentNewDefect));
        }
        private void NavigateDefectViewPage(object sender, SelectionChangedEventArgs e)
        {
            Frame.Navigate(typeof(ApartmentDefectViewPagexaml));
        }
    }
}
