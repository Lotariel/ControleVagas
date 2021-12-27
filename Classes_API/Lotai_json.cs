using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_API
{
    public class Lotai_json
    {
        public class atributos
        {
            public string Nome { get; set; }
            public string Raça { get; set; }
            public string Arma { get; set; }
            public string Sexo { get; set; }
            public List<string> Habilidades { get; set; }
        }
    }
}
