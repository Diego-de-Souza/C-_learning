using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_De_Excecao
{
    /*==============================================================================
     * O que é uma exceção
     * Trata-se de um evento, que ocorre durante a execução do programa, e acaba rompendo o fluxo normal de excecução.
     * Muitos erros de execução podem causar exceções .Exemplos:
     * Divisão por zero;
     * Acessar um objeto nulo;
     ==============================================================================*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int i = Convert.ToInt32(Console.ReadLine());

            try //(tentar) obrigatório - sempre será executado
            {
                int resultado = 10 / i;
                if(resultado < 0)
                {
                    //forçando uma exceção
                    throw new Exception("O resultado " + resultado + " é menor que zero");
                }
                else
                {
                    Console.WriteLine("Resultado da divisão:" + resultado);
                }
            }
            catch (DivideByZeroException e/*Tipo da exceçção a ser gerenciada - tratada*/) //(pegar) obrigatório - só o executado
            {
                Console.WriteLine("Exceçção: "+e.Message);
            }
            catch (Exception e)// caso tenha uma exceção desconhecida ele será executado
            {
                Console.WriteLine("Exceção genérica: " + e.Message);
            }
            finally //(finalmente) opcional - sempre será executado
            {
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }

            
        }
    }
}
