using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
    static void Main(string[] args)
    {
        // Faça um programa que receba o nome de alguém e imprima: “Olá, meu nome é{ nome_recebido}

        string nome;

        Console.Write(" Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("-----------------------");
        Console.WriteLine("Olá, meu nome é " + nome);

        Console.ReadKey();
    }
    }

