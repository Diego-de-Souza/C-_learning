using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        /*========================================================================
         * O que é um metodo
         * Semelhante a uma função, entretanto estão dentro de classes;
         * são blocos de códigos que podem ser chamados repetidas vezes
         * 
         * descrição:
         * tipo_de_acesso modificador_de_instancia tipo_de_retorno nome_do_metodo(parametros_de_entrada
         ========================================================================*/

        public static double Soma(double x, double y)
        {
            double resultadoSoma = x + y;
            return resultadoSoma;
        }

        public static void ImprimeMensagem()
        {
            Console.WriteLine("Olá este é um metodo vazio");
            Console.WriteLine("Um método que não retorna nada");
        }

        /*============================================================
         * ref - sinaliza que o parâmetro de entrada  PODE ser modificado pelo método
         * out - sinaliza que o parâmetro de entrada DEVE ser modificado pelo método
         ============================================================*/

        public static void Multiplica(double a,double b, ref double resultadoDaOperacao)
        {
            double resultadoMultiplicacao = a * b;
            resultadoDaOperacao = resultadoMultiplicacao;
        }
        static void Main(string[] args)
        {
            //chamando metodos
            double resultado = Soma(10, 20);
            Console.WriteLine("Oresultado da soma de 10 e 20 é: "+ resultado);

            double numero1 = 20;
            double numero2 = 20.5;
            resultado = Soma(numero1, numero2);
            Console.WriteLine("O resultado da soma de " + numero1 + " + " + numero2 + " = " + resultado);

            ImprimeMensagem();

            double resultadoDaMultiplicacao = 0;
            Multiplica(numero1, numero2, ref resultadoDaMultiplicacao); //o parametro que tem o ref será atribuido
            Console.WriteLine("O resultado da multiplicação é: " + resultadoDaMultiplicacao);

            
            Console.ReadKey();
        }
    }
}
