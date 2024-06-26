﻿using Microsoft.UI.Xaml.Controls;

using TestRelativePanel.ViewModels;

namespace TestRelativePanel.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
