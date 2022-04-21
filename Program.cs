using System;
using System.Linq;

namespace InfinitosParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularMedia(5, 3, 4, 5, 10, 123, 3).ToString());
            Console.WriteLine(CalcularSoma(5, 3, 4, 5, 10, 123, 3).ToString());
            
            /* INTERESSANTE PARA ADICIONAR EM FORMULÁRIOS NAS QUAIS POSSUEM 
            MUITOS COMPONENTES QUE NECESSITAM ESTAR PREENCHIDOS*/
            Console.WriteLine(VerificarVazios("", "oi", "teste").ToString());// TRUE = TEM VAZIO, FALSE = NÃO TEM VAZIO;

            Console.ReadLine();
        }

        public static int CalcularMedia(params int[] valores)
        {
            int TotalSoma = 0;
            foreach (int i in valores)
            {
                TotalSoma += i;
            }
            return TotalSoma/valores.Length;
        }

        public static int CalcularSoma(params int[] valores)
        {
            int Soma = 0;
            foreach (int i in valores)
            {
                Soma += i;
            }
            return Soma;
        }

        public static bool VerificarVazios(params string[] valores)
        {
            foreach (string str in valores)
            {
                if (str != string.Empty)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
