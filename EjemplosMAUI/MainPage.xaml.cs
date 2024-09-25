﻿using EjemplosMAUI.Pages;
using System.Diagnostics;
using System.Timers;

namespace EjemplosMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnRelojPageClic(object? sender, EventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón OnRelojPageClic clickeado");
            await Shell.Current.GoToAsync(nameof(RelojPage));
        }
        async void OnScannerQRPageClic(object? sender, EventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón OnScannerQRPageClic clickeado");
            await Shell.Current.GoToAsync(nameof(ScannerQRPage));
        }
    }

}
