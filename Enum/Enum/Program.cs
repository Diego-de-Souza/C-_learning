using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum NotasDeReal_e
        {
            NotaDe2 = 2,
            NotaDe5 = 5,
            NotaDe10 = 10
        };

        enum NotaDaProva_e
        {
            Nota0 =0,
            Nota1,
            Nota2,
            Nota3,
            Nota4
        }
        static void Main(string[] args)
        {
            NotasDeReal_e minhaNota = NotasDeReal_e.NotaDe10;
            Console.WriteLine(minhaNota + " vale " + Convert.ToInt32(minhaNota));
            

            NotaDaProva_e minhaNotaProva = NotaDaProva_e.Nota4;
            Console.WriteLine(minhaNotaProva + " vale " + Convert.ToInt32(minhaNotaProva));
            Console.ReadKey();
        }
    }
}
