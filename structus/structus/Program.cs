using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structus
{
    internal class Program
    {
        struct DadosCadastrais
        {
            public string nome;
            public string nomeDaRua;
            public UInt32 numeroDaCasa;
            public DateTime dataNascimento;
        }
        static void Main(string[] args)
        {
            DadosCadastrais meuCadastro;
            meuCadastro.nome = "Diego";
            meuCadastro.nomeDaRua = "João Saldanha";
            meuCadastro.numeroDaCasa = 652;
            meuCadastro.dataNascimento = Convert.ToDateTime("17/01/1988");

            Console.WriteLine(meuCadastro.nome);
            Console.WriteLine(meuCadastro.nomeDaRua);
            Console.WriteLine(meuCadastro.numeroDaCasa);
            Console.WriteLine(meuCadastro.dataNascimento);


            DadosCadastrais meuCadastro2;
            meuCadastro2.nome = "Thais";
            meuCadastro2.nomeDaRua = "Rua regente Feijó";
            meuCadastro2.numeroDaCasa = 502;
            meuCadastro2.dataNascimento = Convert.ToDateTime("15/10/1992");

            Console.WriteLine(meuCadastro2.nome);
            Console.WriteLine(meuCadastro2.nomeDaRua);
            Console.WriteLine(meuCadastro2.numeroDaCasa);
            Console.WriteLine(meuCadastro2.dataNascimento);

            Console.ReadKey();
        }
    }
}
