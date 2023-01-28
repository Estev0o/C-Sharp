using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

        //Leia dois números inteiros e imprima o maior deles, caso sejam iguais, informar “Valores iguais”.


        Console.Write("Digite um numero, A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite um numero, B: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("A vale:"+a+ ", e B vale:" +b+ ". Portanto, A maior que B");
        }

        else if (b > a)
        {
            Console.WriteLine("B vale:" + b + ", e A vale:" + a + ". Portanto, B maior que A");
        }

        else
        {
            Console.WriteLine("A vale:" + a + ", e B vale:" + b + ". Portanto, numeros iguais");
        }

        Console.ReadKey();
    }
}
