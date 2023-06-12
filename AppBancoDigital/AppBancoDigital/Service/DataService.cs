using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AppBancoDigital.Service
{
    public class DataService
    {
        private static readonly string servidor = "http://10.0.2.2:8000";

        protected static async Task<string> GetDataFromService(string rota)
        {
            string json_response;

            string uri = servidor + rota;

            var current = Connectivity.NetworkAccess;

            if (current != NetworkAccess.Internet)
            {
                throw new Exception("Por favor, conecte-se à Internet");
            }

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                Console.WriteLine("_______________________________");
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine("_______________________________");

                if (response.IsSuccessStatusCode)
                {
                    json_response = response.Content.ReadAsStringAsync().Result;
                }
                else
                    throw new Exception(DecodeServerError(response.StatusCode));
            }

            return json_response;
        }
    }
}
