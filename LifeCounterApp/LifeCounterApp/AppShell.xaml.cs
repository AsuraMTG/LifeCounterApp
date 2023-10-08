using System;
using System.Collections.Generic;
using LifeCounterApp.ViewModels;
using LifeCounterApp.Views;
using Xamarin.Forms;

namespace LifeCounterApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
