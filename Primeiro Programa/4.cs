using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia 2 letras e troque os valores nas respectivas variáveis, e imprima-os antes e depois da inversão.
            int aux;

            Console.WriteLine("Digite um numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro numero vale: "+a);
            Console.WriteLine("Segundo numero vale: " +b);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Agora vai ocorrer a troca de valores ");
            Console.WriteLine("---------------------------------------");

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Agora, o primeiro numero vale: " +a);
            Console.WriteLine("E agora, Segundo numero vale: " + b);

            Console.ReadKey();

        }
    }

