using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia 4 notas, e verifique se o aluno está aprovado, reprovado ou de exame. 
            //Considere: >7 aprovado e <5 Reprovado.

            Console.Write("Digite sua 1º nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite sua 2º nota ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite sua 3º nota ");
            double n3 = double.Parse(Console.ReadLine());

            Console.Write("Digite sua 4º nota ");
            double n4 = double.Parse(Console.ReadLine());

            double md = (n1 + n2 + n3 + n4) / 4;

            if (md > 7)
            {
                Console.WriteLine("Aluno aprovado, com média: " +md);
            }

            else if (md < 5)
            {
                Console.WriteLine("Aluno reprovado, com média: " + md);
            }

            else
            {
                Console.WriteLine("Aluno exame, com média: " + md);
            }

            Console.ReadLine();

        }
    }
