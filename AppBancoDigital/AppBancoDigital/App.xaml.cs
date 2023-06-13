using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using AppBancoDigital.View;
using AppBancoDigital.Model;

namespace AppBancoDigital
{
    public partial class App : Application
    {
        public static Model.Correntista DadosCorrentista { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.Login());
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
