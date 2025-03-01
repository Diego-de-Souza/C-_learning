using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_de_cadastro
{
    internal class Program
    {
        struct DadosCadastrais_Struct
        {
            public string nome;
            public string nomeDaRua;
            public UInt32 numeroDaCasa;
            public string numeroDoDocumento;
        }
        static void Main(string[] args)
        {
            List<DadosCadastrais_Struct> listaDeCadastro = new List<DadosCadastrais_Struct>();
            string opcao;
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    //cadastrar um novo usuario
                    DadosCadastrais_Struct dadosCadastrais;
                    Console.WriteLine("Digite o nome completo:");
                    dadosCadastrais.nome = Console.ReadLine();
                    Console.WriteLine("Digite o nome da rua: ");
                    dadosCadastrais.nomeDaRua = Console.ReadLine();
                    Console.WriteLine("Digite o número da casa: ");
                    dadosCadastrais.numeroDaCasa = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Digite o número do documento: ");
                    dadosCadastrais.numeroDoDocumento = Console.ReadLine();
                    listaDeCadastro.Add(dadosCadastrais);
                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    //encerrar a aplicação
                    Console.WriteLine("Encerrando a aplicação");
                }
                else
                {
                    //opção desconhecida
                    Console.WriteLine("Opção desconhecida!");
                }
            } while (opcao != "s");
            Console.WriteLine("Pressione qualquer tecla para sair");
        }
    }
}
