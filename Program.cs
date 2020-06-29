using System;

namespace Aula27ProjetoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.codigo = 2;
            p1.nome = "Crash Bandicoot N'Sane Triology";
            p1.preco = 69.99f;
            p1.Cadastrar(p1);
        }
    }
}
