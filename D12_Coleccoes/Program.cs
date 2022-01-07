using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_Coleccoes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ArrayList: inteiros

            // 1. Instanciar
            ArrayList listaNumeros = new ArrayList();

            // 2. Adicionar valores com o método Add
            listaNumeros.Add(1);
            listaNumeros.Add(2);
            listaNumeros.Add(3);
            listaNumeros.Add(4);

            // 3. Listar com FOR
            for (int i = 5; i < 11; i++)
            {
                listaNumeros.Add(i);
            }

            // 500 - 520, incremento de 2
            for (int i = 500; i < 521; i = i + 2)
            {
                listaNumeros.Add(i);
            }

            // 4. Listar com FOREACH
            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }


            #endregion

            Console.ReadKey();
            Console.Clear();

            #region ArrayList: strings

            // 1. Instanciar e adicionar valores
            ArrayList listaStrings = new ArrayList()
            {
                "a",
                "b",
                "c",
                "d"
            };

            // 2. Adicionar com o método Add
            listaStrings.Add("C#");
            listaStrings.Add("Microsoft");

            // 3. Adicionar valores pela consola
            Console.WriteLine("Adicione uma string:");
            listaStrings.Add(Console.ReadLine());

            // 4. Listar
            foreach (string item in listaStrings)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ReadKey();
            Console.Clear();

            #region ArrayList: pessoas
            ArrayList listaPessoas = new ArrayList();

            Pessoa pessoa01 = new Pessoa();
            Pessoa pessoa02 = new Pessoa();

            pessoa01.Nome = "Filipe";
            pessoa01.Localidade = "Porto";

            pessoa02.Nome = "Monica";
            pessoa02.Localidade = "Grenoble";

            listaPessoas.Add(pessoa01);
            listaPessoas.Add(pessoa02);

            foreach (Pessoa item in listaPessoas)
            {
                Console.WriteLine($"Nome: {item.Nome}\tLocalidade: {item.Localidade}");
            }

            #endregion

            Console.ReadKey();
            Console.Clear();

            #region ArrayList: Funcionários
            ArrayList listaFuncionarios = new ArrayList();

            Funcionario funcionario01 = new Funcionario();
            Funcionario funcionario02 = new Funcionario();

            funcionario01.Nome = "Filipe";
            funcionario01.Localidade = "Porto";
            funcionario01.Departamento = "IT";

            funcionario02.Nome = "Monica";
            funcionario02.Localidade = "Grenoble";
            funcionario02.Departamento = "RH";

            listaFuncionarios.Add(funcionario01);
            listaFuncionarios.Add(funcionario02);

            foreach (Funcionario item in listaFuncionarios)
            {
                Console.WriteLine($"Nome: {item.Nome}\tLocalidade: {item.Localidade}\tDepartamento: {item.Departamento}");
            }

            #endregion

            #region Generic Collection
            List<int> listNumeros = new List<int>()
                            {
                                1,
                                2,
                                3
                            };
            listNumeros.Add(4);
            #endregion


        }
    }
}
