using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita
            //byte num1 = 100;
            //ushort num2;

            //float num3 = 1250.45f;
            //double num4 = num3;

            //num2 = num1;
            //num3 = num1;

            //char letra = 'C';
            //int numero = letra;
            #endregion

            #region Conversão Explícita 
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500.43f;
            //int num4 = (int)num3;

            //char letra = (char)97;
            #endregion

            #region Conversão Parse 
            //string txtnumero = "1978";
            //int numero = int.Parse(txtnumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57");

            //float num3 = float.Parse("457,75");
            #endregion

            #region Classe Convert
            string texto = Convert.ToString(2500);   
            
            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');
            #endregion

            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
