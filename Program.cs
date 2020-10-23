using System;

namespace Intro.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numero = 15;
            char caracter = 'A';
            string nome = "Elcio";
            int idade = 40;
            float preco = 10.59f;

            Console.WriteLine(numero);
            Console.WriteLine(caracter);
            Console.WriteLine(nome);
            Console.WriteLine(preco);

            Console.WriteLine($"{nome} tem {idade} anos");



        }


    }
}