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

        // Metodo Construtor
        public Carro(string marca, string modelo, string cor, double peso, int anoFabricacao, bool chaveNoContato)
        {
            this.setMarca(marca);
            this.setModel(modelo);
            this.setCor(cor);
            this.setPeso(peso);
            this.setAnoFabricacao(anoFabricacao);
            this.setChaveNoContato(chaveNoContato);
        }

        // Utilizando mais de um construtor neste código
        public Carro() 
        {

        }

        
        // Metodo Getter
        public string getMarca()
        {
            return(this.marca);
        }
        public string getModelo()
        {
            return(this.modelo);
        }
        public string getCor()
        {
            return(this.cor);
        }
        public double getPeso()
        {
            return(this.peso);
        }
        public int getAnoFabricacao()
        {
            return(this.anoFabricacao);
        }
        public bool getChaveNoContato()
        {
            return(this.chaveNoContato);
        }


        // Metodo Setter
        public void setMarca(string　marca)
        {
            this.marca = marca;
        }
        public void setModel(string modelo)
        {
            this.modelo = modelo;
        }
        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public void setAnoFabricacao(int anoFabricacao)
        {
            this.anoFabricacao = anoFabricacao;
        }
        public void setChaveNoContato(bool chaveNoContato)
        {
            this.chaveNoContato = chaveNoContato;
        }

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
                Console.WriteLine("Motor foi partido com sucesso!\n");
            }
            else
            {
                Console.WriteLine("Coloque a chave no contato!!\n");
            }            
        }

    }
}