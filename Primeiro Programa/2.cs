using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia a idade de 4 alunos e calcule a média das idades.
            int mi;

            Console.WriteLine("Aluno 1, Digite sua idade ");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno 2, Digite sua idade ");
            int a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno 3, Digite sua idade ");
            int a3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno 4, Digite sua idade ");
            int a4 = int.Parse(Console.ReadLine());

            mi = (a1 + a2 + a3 + a4) / 4;

            Console.Write("As médias de idade são de: " +mi);

            Console.ReadKey();

        }
    }
}
