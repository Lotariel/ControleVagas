using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Classes_API
{
    public class HttpInstance
    {
        private static HttpClient httpclientinstancia;

        private HttpInstance()
        {

        }
        public static HttpClient GetInstancia()
        {
            if (httpclientinstancia == null)
            {
                httpclientinstancia = new HttpClient();
                httpclientinstancia.DefaultRequestHeaders.ConnectionClose = false;
            }
            return httpclientinstancia;
        }
    }
}
