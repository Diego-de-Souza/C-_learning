using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cadastro2
{
    internal class Program
    {
        public struct DadosCadastraisStruct
        {
            public string nome;
            public DateTime dataDeNascimento;
            public string nomeDaRua;
            public UInt32 numeroDaCasa;
        }

        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excecao = 2,
        }

        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem) ;
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public static Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if(temp == "s" ||  temp == "S")
            {
                retorno = Resultado_e.Sair;
            }
            else
            {
                minhaString = temp;
                retorno= Resultado_e.Sucesso;
            }
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaData(ref DateTime data, string mensagem) {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Sucesso;
                    }

                }
                catch (Exception ex) { 
                    Console.WriteLine("EXCEÇÃO: "+ex.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }
            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaUInt32(ref UInt32 numeroUInt32, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        numeroUInt32 = Convert.ToUInt32(temp);
                        retorno = Resultado_e.Sucesso;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("EXCEÇÃO: " + ex.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excecao;
                }
            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public static void CadastraUsuario(ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            DadosCadastraisStruct cadastroUsuario;
            cadastroUsuario.nome = "";
            cadastroUsuario.dataDeNascimento = new DateTime();
            cadastroUsuario.nomeDaRua = "";
            cadastroUsuario.numeroDaCasa = 0;
            if(PegaString(ref cadastroUsuario.nome, "Digite o nome completo ou digite para Sair" ) != Resultado_e.Sucesso)
            {
                return;
            }
            if(PegaData(ref cadastroUsuario.dataDeNascimento, "Digite a data de nascimento no formato DD//MM/AAAA ou digite S para sair") != Resultado_e.Sucesso)
            {
                return;
            }
            if(PegaString(ref cadastroUsuario.nomeDaRua, "Digite o nome da rua ou digite S para sair") != Resultado_e.Sucesso)
            {
                return;
            }
            if(PegaUInt32(ref cadastroUsuario.numeroDaCasa, "Digite o número da casa ou digite S para sair") != Resultado_e.Sucesso)
            {
                return;
            }
            ListaDeUsuarios.Add(cadastroUsuario);
        }
        static void Main(string[] args)
        {
            List<DadosCadastraisStruct> listaDeUsuarios = new List<DadosCadastraisStruct> ();
            string opcao;
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair:");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if(opcao == "c")
                {
                    //cadastrar um  ovo usuário
                    CadastraUsuario(ref listaDeUsuarios);
                }else if(opcao == "s")
                {
                    //sair da aplicação
                    MostraMensagem("Encerrando o programa");
                }
                else
                {
                    //opção desconhecida
                    MostraMensagem("Opção desconhecida!");
                }
            } while (opcao != "s");
        }
    }
}
