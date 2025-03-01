using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_5
{
    internal class Program
    {
        public struct DadosCadastraisScrutct
        {
            public string nome;
            public DateTime dataDeNascimento;
            public string nomeDaRua;
            public UInt32 numeroDaCasa;
        }
        public enum Resultado_e
        {
            sucesso = 0,
            sair = 1,
            Excecao = 2,
        }
        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
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
                retorno = Resultado_e.sair;
            }
            else
            {
                minhaString = temp;
                retorno = Resultado_e.sucesso;
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
                    if(temp == "s" || temp == "S")
                        retorno=Resultado_e.sair;
                    else
                    {
                        data=Convert.ToDateTime(temp);
                        retorno = Resultado_e.sucesso;
                    }
                }catch(Exception ex)
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

        public static Resultado_e PegaUInt32(ref UInt32 numero, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.sair;
                    else
                    {
                        numero = Convert.ToUInt32(temp);
                        retorno = Resultado_e.sucesso;
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

        public static void CadastroUsuarios( ref List<DadosCadastraisScrutct> listaDeUsuarios)
        {
            DadosCadastraisScrutct cadastroUsuarios;
            cadastroUsuarios.nome = "";
            cadastroUsuarios.dataDeNascimento = new DateTime();
            cadastroUsuarios.nomeDaRua = "";
            cadastroUsuarios.numeroDaCasa = 0;
            if (PegaString(ref cadastroUsuarios.nome, "Digite o nome completo ou S para sair") != Resultado_e.sucesso)
                return;
            if (PegaData(ref cadastroUsuarios.dataDeNascimento, "Digite a data de nascimento no formato DD/MM/AAAA ou digite S para sair") != Resultado_e.sucesso)
                return;
            if (PegaString(ref cadastroUsuarios.nomeDaRua, "Digite o nome da Rua ou digite S para sair") != Resultado_e.sucesso)
                return;
            if (PegaUInt32(ref cadastroUsuarios.numeroDaCasa, "Digite o numero da casa") != Resultado_e.sucesso)
                return;
            listaDeUsuarios.Add(cadastroUsuarios);

        }
        static void Main(string[] args)
        {
            List<DadosCadastraisScrutct> listaDeUsuarios = new List<DadosCadastraisScrutct>();
            string opcao = "";
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if(opcao == "c")
                {
                    //cadastrar um novo usuario
                    CadastroUsuarios(ref listaDeUsuarios);
                }else if(opcao == "s")
                {
                    //Sair da aplicação
                    MostraMensagem("Encerrando o programa");
                }
                else
                {
                    //opção desconhecida
                    MostraMensagem("Opção desconhecida");
                }
            } while (opcao != "s");
        }
    }
}
