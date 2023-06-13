using AppBancoDigital.Service;
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
        App PropriedadesApp;

        public Login()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppBancoDigital.View.Img.logo.png");
            NavigationPage.SetHasNavigationBar(this, false);

            PropriedadesApp = (App)Application.Current;
        }

        private void btn_criarConta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.CriarConta());
        }

        private async void btn_logar_Clicked(object sender, EventArgs e)
        {
            string[] cpf_pontuado = txt_cpf.Text.Split('.', '-');
            string cpf_digitado = cpf_pontuado[0] + cpf_pontuado[1] + cpf_pontuado[2] + cpf_pontuado[3];

            try
            {
                Model.Correntista c = await DataServiceCorrentista.LoginAsync(new Model.Correntista
                {
                    Cpf = cpf_digitado,
                    Senha = txt_senha.Text,
                });

                if (c.Id != null)
                {
                    App.DadosCorrentista = c;
                    App.Current.MainPage = new NavigationPage(new View.Home());
                }
                else
                    throw new Exception("Dados de login inválidos.");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}