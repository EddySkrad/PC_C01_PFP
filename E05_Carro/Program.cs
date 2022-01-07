using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Carro
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Carro carro01 = new Carro();    // 1º construtor: carro vazio

                carro01.CriarCarro();
                carro01.Listar("1");

                Carro carro02 = new Carro("marca1", "modelo1", "cor1", "matricula1", 1, 10);    // 2º construtor: carro com valores

                carro02.Listar("2");

                Carro carro03 = new Carro("m1", 1, 2);  // 3º construtor: metade do carro

                carro03.CriarCarro02();
                carro03.Listar("3");
            }
            catch (Exception ex)    // capturar o erro numa variável
            {
                Console.WriteLine("\nErro.");
                Console.WriteLine($"Detalhes: {ex.Message}");
                Console.ReadKey();
            }

            

            //Console.ReadKey();

        }
    }
}
