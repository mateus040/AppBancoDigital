﻿using AppBancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {

        public Home()
        {
            InitializeComponent();

            //logo.Source = ImageSource.FromResource("AppBancoDigital.View.Img.logo.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked_Fazer_Pix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.EnviarPix());
        }

        private void Button_Clicked_Receber_Pix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.ReceberPix());
        }
    }
}