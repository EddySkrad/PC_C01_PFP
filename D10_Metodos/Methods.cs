using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10_Metodos
{
    class Methods
    {

        public string Mensagem { get; set; }

        public void VoidMethod()
        {

            Mensagem = "Método Void: não devolve valor";
            Console.WriteLine(Mensagem);

        }

        public string NoVoidMethod()
        {
            Mensagem = "Método No Void: devolve valor";
            return Mensagem;
        }

    }
}
