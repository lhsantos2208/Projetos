using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Condicionais Simples
            //int valor = 10;

            //if (valor == 5)
            //{
            //    Console.WriteLine("Condição Verdadeira!");
            //}
            //else
            //{
            //    Console.WriteLine("Condição Falsa!");
            //}
            #endregion

            #region Condicionais Encadeadas 
            //int valor = 21;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição Verdadeira!");
            //}
            //else if (valor >= 5 && valor < 10) 
            //{
            //    Console.WriteLine("Condição Alternativa 1!");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição Alternativa 2!");
            //}
            //else
            //{
            //    Console.WriteLine("Condição Alternativa Final!");
            //}
            #endregion

            #region Condicionais Aninhadas
            //int numero = 11;

            //if (numero > 5)
            //{
            //    Console.Write("O número é maior que 5");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" e também é par.");
            //    } 
            //    else
            //    {
            //        Console.WriteLine(" mas não é par.");
            //    }
            //}
            #endregion

            #region Operador Ternario
            int numero = 3;
            string mensagem = "";

            // condição ? true : false;
            mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            //if (numero > 5)
            //{
            //    mensagem = "Maior que 5";
            //}
            //else
            //{
            //    mensagem = "Menos que 5";
            //}
            Console.WriteLine(mensagem);
            #endregion

            Console.ReadKey();
        }
    }
}
