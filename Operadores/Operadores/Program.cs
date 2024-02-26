using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores matemáticos
            //int num1 = 15;
            //int num2 = 2;
            //int resultado = num1 + num2;
            //int resultado2 = num1 - num2;
            //int resultado3 = num1 * num2;
            //int resultado4 = num1 / num2;
            //int resultado5 = num1 % num2;

            //Console.WriteLine(resultado);
            //Console.WriteLine(resultado2);
            //Console.WriteLine(resultado3);
            //Console.WriteLine(resultado4);
            //Console.WriteLine(resultado5);
            #endregion

            #region Precedência de Operadores
            //double num1 = 100;
            //double num2 = 10;
            //double num3 = 5;

            //int res = num1 + num2 * num3;

            //int res2 = (num1 + num2) * num3;

            //int res3 = (num1 + num2) * num3 / 2;

            //int res4 = (num1 + num2) * (num3 / 2);

            //double res5 = (num1 + num2) * (num3 / 3);

            //Console.WriteLine(res5);
            #endregion

            #region Incremento e decremento
            //int num1 = 10;

            //num1++;

            //int num2 = 10;
            //++num2;

            //int num3 = 10;

            //int num4 = 10;

            //int num5 = 10;

            //int num6 = 10;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3++);
            //Console.WriteLine(num3);
            //Console.WriteLine(++num3);
            //Console.WriteLine(num3);
            //Console.WriteLine(num5--);
            //Console.WriteLine(num5);
            //Console.WriteLine(--num5);
            //Console.WriteLine(num5);
            #endregion

            #region Concatenação
            //string nome = "Luciano";
            //string sobrenome = "Santos";
            //string nomeCompleto = nome + " " + sobrenome;

            //Console.WriteLine(nomeCompleto);
            #endregion

            #region Operadores Atribuição
            //int num1 = 10;
            //int num2 = 20;
            //int num3 = 30;
            //int num4 = 50;
            //int num5 = 10;
            //string nome = "Luciano";

            //num1 += 20;
            //num2 -= 10;
            //num3 *= 10;
            //num4 /= 10;
            //num5 %= 2;
            //nome += " Santos";

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine(num5);
            //Console.WriteLine(nome);
            #endregion

            #region Operadores Igualdade/Comparação
            //bool res = 100 == 50;
            //bool res1 = 100 == (50 * 2);
            //bool res2 = 200 != 100 + 100;
            //bool res3 = (200 / 100) != (100 + 100);

            //string nome = "Luciano";
            //bool res4 = nome == "Lilian";
            //bool res5 = nome != "Lilian";

            //Console.WriteLine(res);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            //Console.WriteLine(res4);
            //Console.WriteLine(res5);
            #endregion

            #region Operadores Relacionais
            //bool res = 100 < 50;
            //bool res1 = 100 < (50 + 65);
            //bool res2 = 100 < (50 * 2);
            //bool res3 = 100 > (50 * 2);
            //bool res4 = (100 + 25) > (50 * 2);
            //bool res5 = 45 <= (50 * 2);
            //bool res6 = 45 >= (50 * 2);

            //Console.WriteLine(res);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            //Console.WriteLine(res4);
            //Console.WriteLine(res5);
            //Console.WriteLine(res6);
            #endregion

            #region Operadores Lógicos 
            bool res1 = 100 > 50;
            bool res2 = 50 == 50;
            bool final = res1 && res2;
            bool res3 = 50 != 50;
            bool final1 = res1 && res3;
            bool final2 = res1 || res2;

            Console.WriteLine(final);
            Console.WriteLine(final1);
            Console.WriteLine(final2);
            #endregion

            Console.ReadKey();
        }
    }
}
