﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class teste
    {
        // Definição de um campo
        private string _nome;
        public string Sobrenome { get; } = "Santos";
        private int _idade;

        // Definição de uma propriedade
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Não é permitido atribuir valores menor que 18 anos.");
                }
                else
                {
                    _idade = value;
                }
            }
        }

        public void Apresentar()
        {
            if (_nome != "")
            {
                Console.WriteLine("Bem vindo " + _nome);
            }
        }
    }
}
