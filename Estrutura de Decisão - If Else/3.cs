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
            /*Faça um programa que leia a nota e a porcentagem de frequência de um aluno e apresente se este está aprovado ou reprovado. 
            Considere que para estar aprovado, o mesmo deve ter média >=7 e frequência >= 75 %.*/

            Console.Write("Digite sua nota: ");
            double n = double.Parse(Console.ReadLine());

            Console.Write("Digite sua frequencia: ");
            double f = double.Parse(Console.ReadLine());

            if (n >=7 && f>=75)
            {
                Console.WriteLine("Aluno aprovado com nota "+n+ " e frequência de: " + f +"%");
            }

            else
            {
                Console.WriteLine("Aluno reprovado com nota " + n + " e frequência de: " + f +"%");
            }

            Console.ReadKey();



        }
    }
}
