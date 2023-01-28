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

            //Leia um número digitado pelo usuário e informe o número e se é ímpar ou par.

            Console.Write("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Numero:" +x+ ",par!");
            }

            else
            {
                Console.WriteLine("Numero:" +x+ ",impar!");
            }

            Console.ReadKey();
        }
    }
}
