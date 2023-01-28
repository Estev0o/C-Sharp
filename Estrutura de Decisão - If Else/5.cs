using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
    static void Main(string[] args)
        {
        //Leia o ano de nascimento de uma pessoa e informe se ela poderá votar este ano atual. ( Desconsidere o mês de nascimento)

        int y;

        Console.WriteLine("Digite o ano de seu nascimento: ");
        int ano = int.Parse(Console.ReadLine());

        y = 2022 - ano;

        if (y > 18)
        {
            Console.WriteLine("Pode votar!");
        }

        else
        {
            Console.WriteLine("Nao pode votar!");
        }

        Console.ReadKey();
        }

    }
