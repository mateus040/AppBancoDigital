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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppBancoDigital.View.Img.logo.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btn_criarConta_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.CriarConta());
        }

        private async void btn_logar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new FormAdd());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }
    }
}