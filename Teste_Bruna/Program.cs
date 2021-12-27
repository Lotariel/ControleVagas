using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Bruna
{
    class Program
    {
        static void Main(string[] args)
        {
            string Genero = "0";
            int Idade;
            string RespostaCliente;

            Console.WriteLine("Selecione seu genero\n1 Feminino  2 Masculino");
            Genero = Console.ReadLine();

            if (Genero == "1" || Genero == "2")
            {

               
            }
            else
            {
                

                while (Convert.ToInt32(Genero) > 2)
                {                    
                    Console.WriteLine("Digite apenas opção 1 ou 2\nSelecione seu genero\n1 Feminino  2 Masculino");
                    Genero = Console.ReadLine();
                }


            }

            string Definir_Genero(string GeneroDoCliente)
            {
                if (GeneroDoCliente == "1")
                {
                    GeneroDoCliente = "Feminino";
                    return GeneroDoCliente;
                }
                else
                {
                    GeneroDoCliente = "Masculino";
                    return GeneroDoCliente;
                }
                
            }


            Console.ReadKey();
        }
    }
}
