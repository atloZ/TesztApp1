using System;
using TesztApp1.Services;
using TesztApp1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesztApp1
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
