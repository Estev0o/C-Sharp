using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
        //Faça um programa que leia a hora digitada e imprima “Bom dia” ou “Boa tarde”, usando operador ternário.

        Console.WriteLine("Insira um horário ");
        int a = int.Parse(Console.ReadLine());

        Console.Write(a >= 6 && a < 12 ? " Bom dia " : "Boa tarde");

        Console.ReadKey();

    }
}

