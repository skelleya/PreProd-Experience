using PreProd_Experience.Services;
using PreProd_Experience.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PreProd_Experience
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
