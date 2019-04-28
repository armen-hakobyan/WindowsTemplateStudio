﻿using System;
using Windows.UI.Xaml.Controls;

namespace Param_RootNamespace.Views
{
    public sealed partial class ContentGridViewPage : Page
    {
        public ContentGridViewPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
