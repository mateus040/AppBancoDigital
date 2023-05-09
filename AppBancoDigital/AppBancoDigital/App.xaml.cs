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
        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Cpf = "561.822.558-11",
                Senha = "123"
            }
        };

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new FormAdd();
            else
                MainPage = new Login();
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
