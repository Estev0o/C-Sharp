using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia e atribua a suas respectivas variáveis o nome, rua, número e bairro e cidade de uma pessoa, e imprima tudo em uma única saída.

            Console.WriteLine("Insira seu nome: ");
            string n = Console.ReadLine();

            Console.WriteLine("Insira sua rua: ");
            string r = Console.ReadLine();

            Console.WriteLine("Insira o numero da rua: ");
            int nr = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu bairro: ");
            string b = Console.ReadLine();

            Console.WriteLine("Insira sua cidade: ");
            string c = Console.ReadLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Nome: "+n);
            Console.WriteLine("Rua: "+r);
            Console.WriteLine("Numero da rua: "+nr);
            Console.WriteLine("Bairro: " + b);
            Console.WriteLine("Cidade: " + c);

            Console.ReadKey();

        }
    }
}
