using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_API
{
   public class olinda_json
    {
        public class Value
        {
            public double cotacaoCompra { get; set; }
        }

        public class Root
        {
            [JsonProperty("@odata.context")]
            public string OdataContext { get; set; }
            public List<Value> value { get; set; }
        }


    }
}
