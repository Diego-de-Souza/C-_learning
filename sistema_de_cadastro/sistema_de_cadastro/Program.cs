﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Pressione C para cadastrar um usuário ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    Console.WriteLine("Digite o seu nome completo:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Pressione M para masculino e F para feminino:");
                    char genero = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("Digite a data de nascimento no formato dd/mm/aaaa:");
                    DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o nome da sua rua:");
                    string nomeDaRua = Console.ReadLine();
                    Console.WriteLine("Digite o número da casa:");
                    UInt32 numeroDaCasa = Convert.ToUInt32(Console.ReadLine());
                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    Console.WriteLine("Encerrando o programa");
                }
                else
                {
                    Console.WriteLine("Opção desconhecida");
                }
            } while (opcao != "s");
        }
    }
}
