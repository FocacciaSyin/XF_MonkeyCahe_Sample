using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MonkeyCache_Sample.Services;
using MonkeyCache_Sample.Views;

namespace MonkeyCache_Sample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
