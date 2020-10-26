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

            Console.WriteLine("\nTreinando Casting");
            int i = 1000;
            // Casting - Conversão explícita
            // Se o i for maior que 255 então haverá perda de valor
            // se converter para byte porque o range do byte é entre 0 e 255
            byte byte1 = (byte) i;
            Console.WriteLine(byte1);

            Console.WriteLine("\nTreinando conversao de dados e try..catch..");
            
            try
            {
                Console.Write("Digite um número byte a ser convertido: ");
                string numero2 = Console.ReadLine();
                byte byte2 = Convert.ToByte(numero2);
                Console.WriteLine($"O número convertido é {byte2}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"O número tem que estar entre {byte.MinValue} e {byte.MaxValue}");
            }
        }
    }
}