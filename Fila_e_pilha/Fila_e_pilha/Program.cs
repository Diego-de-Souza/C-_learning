using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_e_pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fila = Queue
            Queue<string> filaDeNomes = new Queue<string>();
            //adicionando elementos
            filaDeNomes.Enqueue("Diego");
            filaDeNomes.Enqueue("Thais");
            filaDeNomes.Enqueue("Emilly");
            filaDeNomes.Enqueue("Thomas");
            filaDeNomes.Enqueue("Lorrane");
            filaDeNomes.Enqueue("Anderson");
            filaDeNomes.Enqueue("Testting");

            //removendo elementos
            string nomeRemovido = filaDeNomes.Dequeue();
            Console.WriteLine(nomeRemovido);
            nomeRemovido = filaDeNomes.Dequeue();
            Console.WriteLine(nomeRemovido);

            //espiando elementos
            Console.WriteLine("----------------");
            string nomeEspiando = filaDeNomes.Peek();
            Console.WriteLine(nomeEspiando);

            //pilha = stack
            Console.WriteLine("----------------");
            Stack<string> pilhaDeNomes = new Stack<string>();
            pilhaDeNomes.Push("Diego");
            pilhaDeNomes.Push("Thais");
            pilhaDeNomes.Push("Emilly");
            pilhaDeNomes.Push("Thomas");
            pilhaDeNomes.Push("Lorrane");
            pilhaDeNomes.Push("Anderson");
            pilhaDeNomes.Push("Testting");

            //removendo elementos
            string nomePilharemovido = pilhaDeNomes.Pop();
            Console.WriteLine(nomePilharemovido);
            nomePilharemovido = pilhaDeNomes.Pop();
            Console.WriteLine(nomePilharemovido);

            //espiando elementos na pilha
            nomePilharemovido = pilhaDeNomes.Peek();
            Console.WriteLine(nomePilharemovido);


            Console.ReadKey();
        }
    }
}
