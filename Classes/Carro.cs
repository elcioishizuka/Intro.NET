using System;

namespace Classes
{
    public class Carro
    {
        public string marca;
        public string modelo;
        public string cor;
        public double peso;
        public int anoFabricacao;
        public bool chaveNoContato;
        
        public void mostrarDados()
        {
            System.Console.WriteLine($"\nMarca: {this.marca}");
            System.Console.WriteLine($"Modelo: {this.modelo}");
            System.Console.WriteLine($"Ano de Fabricação: {this.anoFabricacao}");
            System.Console.WriteLine($"Cor: {this.cor}");
            System.Console.WriteLine($"Peso: {this.peso}");
            System.Console.WriteLine($"Chave no contato? {this.chaveNoContato}\n");
        }

        public void partirMotor ()
        {
            if (this.chaveNoContato == true)
            {
                Console.WriteLine("Motor foi partido com sucesso!");
            }
            else
            {
                Console.WriteLine("Coloque a chave no contato!!");
            }            
        }

    }
}