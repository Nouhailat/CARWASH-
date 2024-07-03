using System;
using TandiifCom.menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TandiifCom
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutPage1();
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
