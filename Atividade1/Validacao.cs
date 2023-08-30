using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Validar : Dados
    {
        public Validar(string nome, string ra) : base(nome, ra)
        {
        }
        public void Validacao()
        {
            if (nome == "Kristyano" && ra == "N7920F9") {

                Console.WriteLine("Nome corresponde ao RA!");

            }
            else
            {
                Console.WriteLine("Nome não corresponde ao RA!");
            }
        }
    }
}
