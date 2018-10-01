using Newtonsoft.Json;
using System.Net;
using viaCEP.Modelo;

namespace viaCEP.Servicio
{
    public class ViaCEPServicio
    {
        private static string EndecoreURL = "http://viacep.com.br/ws/{0}/json/";

        public static object Conteudo { get; private set; }

        public static Endereco BuscarEndecoreViaCEP(string cep)
        {
            string nuevaURL = string.Format(EndecoreURL, cep);

            WebClient wc = new WebClient();
            string contenido = wc.DownloadString(nuevaURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(contenido);

            return end;
        }
    }
}

