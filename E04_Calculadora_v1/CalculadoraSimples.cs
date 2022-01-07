using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculadoraSimples
    {
        #region Properties
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public string Operador { get; set; }
        public double Resultado { get; set; }
        #endregion

        #region Methods
        
        public void MostrarOperadores()
        {
            //Console.WriteLine("[+]\n[-]\n[*]\n[/]");

            Console.WriteLine("Operadores:");
            string[] operadores = new string[] { "[+]", "[-]", "[*]", "[/]" };

            foreach (string operador in operadores)
            {
                Console.WriteLine(operador);
            }


        }
        
        public void LerValor1()
        {
            Console.Write("Valor 1: ");
            Valor1 = Convert.ToDouble(Console.ReadLine());
        }

        public void LerValor2()
        {
            Console.Write("Valor 2: ");
            Valor2 = Convert.ToDouble(Console.ReadLine());
        }

        public void Soma()
        {
            Resultado = Valor1 + Valor2;
        }

        public void Subtracao()
        {
            Resultado = Valor1 - Valor2;
        }

        public void Multiplicacao()
        {
            Resultado = Valor1 * Valor2;
        }

        public void Divisao()
        {
            if (Valor2 == 0)
            {
                Resultado = 0;
            }
            else
            {
                Resultado = Valor1 / Valor2;
            }
        }

        public void VerificarOperador()
        {
            Console.WriteLine("Escolha o operador");
            Operador = Console.ReadLine();
            switch (Operador)
            {
                case "+":
                    Soma();
                    break;
                case "-":
                    Subtracao();
                    break;
                case "*":
                    Multiplicacao();
                    break;
                case "/":
                    Divisao();
                    break;
                default:
                    Console.WriteLine("Operador inválido");
                    break;
            }

        }

        public void MostrarResultado()
        {
            Console.WriteLine($"\nO resultado é: {Resultado}");
        }
        #endregion

        #region Constructors
        public CalculadoraSimples()
        {
            Valor1 = 0;
            Valor2 = 0;
            Operador = string.Empty;    // ""
            Resultado = 0;
        }

        public CalculadoraSimples(double valor1, double valor2, string operador)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            Operador = operador;
            Resultado = 0;
        }
        #endregion

    }
}
