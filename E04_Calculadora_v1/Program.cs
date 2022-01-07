using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            try //tratamento de erro
            {
                CalculadoraSimples calculadoraSimples = new CalculadoraSimples();

                CalculadoraSimples calculadoraSimples2 = new CalculadoraSimples(10, 2, "+");

                calculadoraSimples.MostrarOperadores();
                calculadoraSimples.LerValor1();
                calculadoraSimples.LerValor2();
                calculadoraSimples.VerificarOperador();
                calculadoraSimples.MostrarResultado();
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato do número errado.");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro.");
                //throw;
                // Console.WriteLine(erro.Message); // serve para logar o erro
            }
            
            Console.ReadKey();

        }
    }
}
