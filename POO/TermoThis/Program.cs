﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            if (a.Login("68441316"))
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Acesso Negado!");
            }
            Console.ReadKey();
        }
    }
}
