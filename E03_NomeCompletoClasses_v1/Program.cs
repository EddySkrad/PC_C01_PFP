using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioDadosPessoais
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario01 = new Funcionario();

            funcionario01.LerPrimeiroNome();
            funcionario01.LerNomeMeio();
            funcionario01.LerUltimoNome();

            funcionario01.ConcatenarNomeCompleto();
            funcionario01.EscreverNomeCompleto();

            Console.ReadKey();

        }
    }
}
