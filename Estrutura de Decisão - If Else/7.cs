using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        //Faça um programa que leia dois números, some e apresente se a soma é maior, menor ou igual a 10.

        Console.Write("Digite um numero: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite um numero: ");
        double n2 = double.Parse(Console.ReadLine());


        double sm = n1 + n2;

        if (sm > 10)
        {
            Console.WriteLine("Numero " + sm + " maior que 10 ");
        }

        else if (sm < 10)
        {
            Console.WriteLine("Numero " + sm + " menor que 10 ");
        }

        else
        {
            Console.WriteLine("Numero " + sm + " igual a 10 ");
        }

        Console.ReadLine();

    }
}
