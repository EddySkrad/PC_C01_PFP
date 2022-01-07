using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioDadosPessoais
{
    class Funcionario
    {

        #region Properties
        public string PrimeiroNome { get; set; }
        public string NomeMeio { get; set; }
        public string UltimoNome { get; set; }
        public string NomeCompleto { get; set; }
        #endregion

        #region Methods
        public void LerPrimeiroNome()
        {
            Console.Write("Primeiro Nome: ");
            PrimeiroNome = Console.ReadLine();
        }

        public void LerNomeMeio()
        {
            Console.Write("Nome do Meio: ");
            NomeMeio = Console.ReadLine();
        }

        public void LerUltimoNome()
        {
            Console.Write("Último Nome: ");
            UltimoNome = Console.ReadLine();
        }

        public void ConcatenarNomeCompleto()
        {
            // NomeCompleto = $"{PrimeiroNome} {NomeMeio} {UltimoNome}";

            if (!string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{PrimeiroNome} {NomeMeio} {UltimoNome}";
            }
            else if (!string.IsNullOrEmpty(PrimeiroNome) && string.IsNullOrEmpty(NomeMeio) && string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = PrimeiroNome;
            }
            else if (!string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeMeio) && string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{PrimeiroNome} {NomeMeio}";
            }
            else if (!string.IsNullOrEmpty(PrimeiroNome) && string.IsNullOrEmpty(NomeMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{PrimeiroNome} {UltimoNome}";
            }
            else if (string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeMeio) && string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = NomeMeio;
            }
            else if (string.IsNullOrEmpty(PrimeiroNome) && !string.IsNullOrEmpty(NomeMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = $"{NomeMeio} {UltimoNome}";
            }
            else if (string.IsNullOrEmpty(PrimeiroNome) && string.IsNullOrEmpty(NomeMeio) && !string.IsNullOrEmpty(UltimoNome))
            {
                NomeCompleto = UltimoNome;
            }
            else
            {
                NomeCompleto = "<sem nome>";
            }
        }

        public void EscreverNomeCompleto()
        {
            Console.WriteLine($"\nO nome completo é: {NomeCompleto}");
        }
        #endregion

    }
}
