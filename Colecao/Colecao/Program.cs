using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            //int[] numeros = new int[5];

            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;

            //string[] nomes = new string[4];

            //nomes[0] = "Luciano";
            //nomes[1] = "Lilian";
            //nomes[2] = "Luana";
            //nomes[3] = "Lucas";

            //string[] nomes2 = {"Luciano","Lilian","Luana","Lucas"};

            //nomes2[0] = "Luciano Henrique";

            //Console.WriteLine(numeros[2]);
            //Console.WriteLine(nomes[3]);
            //Console.WriteLine(nomes2[0]);
            #endregion

            #region Array Bidimensionais
            int[,] numeros = new int[2,3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.Write("[" + numeros[0, 0] + "],");
            Console.Write("[" + numeros[0, 1] + "],");
            Console.Write("[" + numeros[0, 2] + "]");
            Console.WriteLine();
            Console.Write("[" + numeros[1, 0] + "],");
            Console.Write("[" + numeros[1, 1] + "],");
            Console.Write("[" + numeros[1, 2] + "]");

            string[,] nomes =
            {
                {"Luciano", "Lilian", "Luana", "Lucas" },
                {"Henrique", "Lourenço", "Santos", "Santos" }
            };

            Console.WriteLine();
            Console.Write(nomes[0, 0] + " ");
            Console.Write(nomes[1, 0]);
            Console.WriteLine();
            Console.Write(nomes[0, 1] + " ");
            Console.Write(nomes[1, 1]);
            Console.WriteLine();
            Console.Write(nomes[0, 2] + " ");
            Console.Write(nomes[1, 2]);
            Console.WriteLine();
            Console.Write(nomes[0, 3] + " ");
            Console.Write(nomes[1, 3]);
            #endregion

            Console.ReadKey();
        }
    }
}
