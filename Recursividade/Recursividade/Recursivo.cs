using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Recursivo
    {
        // Metodo não recursivo
        public void Executar(string mensagem, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem);
            }
        }

        // Metodo recursivo
        public void ExecutarRecursiva(string mensagem, int n)
        {
            if (n > 0)
            {
                Console.WriteLine(mensagem);
                ExecutarRecursiva(mensagem, n - 1);
            }
        }
    }
}
