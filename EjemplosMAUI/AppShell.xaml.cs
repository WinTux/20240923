﻿using EjemplosMAUI.Pages;

namespace EjemplosMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RelojPage), typeof(RelojPage));
        }
    }
}
