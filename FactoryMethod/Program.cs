using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabricaDeVeiculo = new FabricaDeVeiculo();
            
            //Tesla
            var veiculo1 = fabricaDeVeiculo.CrieVeiculo("Chuva", 2, "Eletricidade");
            Console.WriteLine("Criou o veículo "+ veiculo1.GetType().Name);

            //Opala
            var veiculo2 = fabricaDeVeiculo.CrieVeiculo("Chuva", 5, "Gasolina");
            veiculo2.ExibaNome();

            //Escort
            var veiculo3 = fabricaDeVeiculo.CrieVeiculo("Sol", 5, "Alcool");
            veiculo3.ExibaNome();

            //Besta
            var veiculo4 = fabricaDeVeiculo.CrieVeiculo("Chuva", 6, "Diesel");
            veiculo4.ExibaNome();

            //Tesla
            var veiculo5 = fabricaDeVeiculo.CrieVeiculo("Sol", 5, "Eletricidade");
            Console.WriteLine("Criou o veículo " + veiculo5.GetType().Name);

            Console.ReadKey();
        }
    }
}
