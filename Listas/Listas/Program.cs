using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>();

            //adicionar elementos
            listaDeNomes.Add("Diego");
            listaDeNomes.Add("Thais");
            listaDeNomes.Add("Emilly");
            listaDeNomes.Add("Thomas");

            //removendo elemento
            listaDeNomes.Remove("Diego");

            //removendo elementos em posições especificas
            listaDeNomes.RemoveAt(0);

            foreach (string nome in listaDeNomes) {
                Console.WriteLine(nome);
            }

            Console.WriteLine(" ================================================ \n");

            List<string> listaDeObjetos = new List<string>();

            listaDeObjetos.Add("caneta");
            listaDeObjetos.Add("carteira");
            listaDeObjetos.Add("computador");
            listaDeObjetos.Add("mouse");
            listaDeObjetos.Add("impressora");
            listaDeObjetos.Add("bolsa");

            //removendo uma faixa de elementos
            listaDeObjetos.RemoveRange(1, 2);

            //pegando o número de elementos
            Console.WriteLine("A lista listaDeObjetoss possui: " + listaDeObjetos.Count + " elementos");

            foreach (string objetos in listaDeObjetos)
            {
                Console.WriteLine(objetos); 
            }

            Console.WriteLine("============================================ \n");

            //concatenando listas
            List<string> listaDeLinguagens = new List<string>();
            listaDeLinguagens.Add("JavaScript");
            listaDeLinguagens.Add("Python");
            listaDeLinguagens.Add("Java");
            listaDeLinguagens.Add("Kotlin");
            List<string> listaDeLinguagens2 = new List<string>();
            listaDeLinguagens2.Add("C#");
            listaDeLinguagens2.Add("C++");
            listaDeLinguagens2.Add("Cobol");
            listaDeLinguagens2.Add("Assembly");

            //unindo listas em uma unica lista
            List<string> listaCompletaLing = listaDeLinguagens.Concat(listaDeLinguagens2).ToList();

            foreach (string ling in listaCompletaLing) { 
                Console.WriteLine(ling);
            }

            //verificando se a lista possui um determinado valor
            bool contemNome = listaCompletaLing.Contains("Java");
            Console.WriteLine("\nA lista de linguagens contem Java?");
            Console.WriteLine(contemNome);

            bool contemNome2 = listaCompletaLing.Contains("Flutter");
            Console.WriteLine("A lista de linguagens contem Flutter?");
            Console.WriteLine(contemNome2);

            //descobrindo o índice de um elemento
            int indice = listaCompletaLing.IndexOf("Kotlin");
            Console.WriteLine("O indice da linguagem Kotlin é: "+indice);

            Console.WriteLine("============================================ \n");

            //Operador where
            List<string> listaWhere = listaCompletaLing.Where(x => x.StartsWith("C")).ToList();
            foreach(string nome in listaWhere)
            {
                Console.WriteLine(string);
            }

            Console.ReadKey();
        }
    }
}
