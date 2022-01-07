using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Methods method01 = new Methods();

            method01.VoidMethod();
            Console.WriteLine(method01.NoVoidMethod());

            Console.ReadKey();
        }
    }
}
