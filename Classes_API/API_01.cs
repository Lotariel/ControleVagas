using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;


namespace Classes_API
{
    public class API_01
    {
        
        

   
        public string Base_URI()
        {
            //return "http://api.musixmatch.com/ws/1.1/";

            return "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/";
        }
        

        

        public string Retorno_Request()
        {
            //string action = "track.search?q_artist=justin bieber&page_size=3&page=1&s_track_rating=desc";
            string action = "CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao='06-13-2017'&$top=100&$format=json&$select=cotacaoCompra";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get,Base_URI() + action);

            HttpResponseMessage response = HttpInstance.GetInstancia().SendAsync(request).Result;

            if (response.ReasonPhrase =="OK")
            {
                string resultado = response.Content.ReadAsStringAsync().Result;
                return resultado;
            }
            else
            {
                return "Não deu certo";
            }
        }

        public string Trata_Json(string json)
        {
            var js = new DataContractSerializer(typeof (olinda_json.Value));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var olinda = (olinda_json.Value)js.ReadObject(ms);
            return olinda.cotacaoCompra.ToString();
            
        
        }
    }
  
}
