using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            //Leia um número inteiro e informe se este é divisível por 3.

            Console.Write("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 3 == 0)
            {
                Console.WriteLine("Numero " + x + ", divisivel por 3");
            }

            else
            {
                Console.WriteLine("Numero " + x + ", nao divisivel por 3");
            }

            Console.ReadKey();

        }
    }
