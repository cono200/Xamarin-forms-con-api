using CorredoresF1App_SLE.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorredoresF1App_SLE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vcorredor();
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
