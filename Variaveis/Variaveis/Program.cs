using System;

namespace Variaveis
{
    internal class Program
    {
        enum Notas
        {
            Minimo, 
            Media, 
            Maxima
        }
        
        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }
        
        static void Main(string[] args)
        {
            #region Numericas Integrais
            // Integral assinado
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, -32.768 a 32.767
            //int num3 = 30; // 32 bits, -2.147.486.648 a 2.147.483.647
            //long num4 = 40L; // 64 bist, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.808

            //// Integral sem sinal
            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 20; // 16 bits, de 0 a 65.535
            //uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
            //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero;
            //numero = 100;

            //numero = 120;
            //numero = num1;
            #endregion

            #region Numeros Reais
            //float real1 = 100.75f; // 32 bits, intervalo de 1,5 x 10.45 a 3,4 x 1038, precisao de 7 digitos => Sufixo f, Ex.: 10.5f 
            //double real2 = 500.754; // 64 bits, intervalo de 5,0 x 10-324 a 1,7 x 10308, precisão de 15 dígitos => Sufixo d (opcional)
            //decimal real3 = 752538.457m; // 128 bist, intervalo de pelo menos -7,9 x 10-28 a 7,9 x 1028, com precisão de pelo menos 28 digitos => Sufixo m, Ex.: 10.5m

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere
            //char letra = '\u0061';
            //char escape = '\\';
            //char literal = 'C';
            #endregion

            #region booleano 
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region string
            //string texto = "Luciano Henrique\n 1978";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Var
            //var valor = 140;
            #endregion

            #region object
            //object obj = 10;
            //obj = false;
            //obj = "Luciano";
            #endregion

            #region Constant 
            //const double pi = 3.1415;
            //const string nome = "Luciano";
            #endregion

            #region Enumeração
            //Notas notasAlunos = Notas.Media;
            #endregion

            #region Struct
            Pessoa p1 = new Pessoa();
            p1.nome = "Luciano Henrique";
            p1.altura = 1.68;
            p1.idade = 45;

            Pessoa p2 = new Pessoa()
            {
                nome = "Zico",
                altura = 1.70,
                idade = 70
            };
            #endregion

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.altura);
            Console.WriteLine(p1.idade);
            Console.WriteLine();
            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.altura);
            Console.WriteLine(p2.idade);
            Console.ReadKey();


        }
    }
}
