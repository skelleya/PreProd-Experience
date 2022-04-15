using PreProd_Experience.ViewModels;
using PreProd_Experience.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PreProd_Experience
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
