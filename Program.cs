using System;
using Classes;

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

            
            // Aprendizado em Programação Orientada a Objeto - Classes e Objetos
            Carro carro1 = new Carro();
            carro1.marca = "Ford";
            carro1.modelo = "Ka";
            carro1.anoFabricacao = 2001;
            carro1.cor = "Preto";
            carro1.peso = 1501.25;
            carro1.chaveNoContato = true;
            carro1.mostrarDados();
            carro1.partirMotor();

            Carro carro2 = new Carro();
            carro2.marca = "Honda";
            carro2.modelo = "Fit";
            carro2.anoFabricacao = 2015;
            carro2.cor = "Prata";
            carro2.peso = 1890.36;
            carro2.chaveNoContato = false;
            carro2.mostrarDados();
            carro2.partirMotor();          


        }
    }
}