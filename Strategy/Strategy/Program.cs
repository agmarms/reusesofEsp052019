using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1ª assinatura
            var preco1 = new Preco(21.90m);
            var transmissaoUnica1 = new TransmissaoUnica();
            var transformadorConteudo1 = new Simples();
            
            var assinatura1 = new Assinatura(preco1, transformadorConteudo1, transmissaoUnica1);
            var qualidadeConteudo1 = transformadorConteudo1.ObtenhaQualidade();

            Console.WriteLine("");
            Console.WriteLine("Valor da assinatura.....: " + assinatura1.ObtenhaPreco());
            Console.WriteLine("Tipo da assinatura......: " + qualidadeConteudo1.ObtenhaQualidade());
            assinatura1.PrepareNumeroTransmissoes();

            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("");


            // 2ª assinatura
            var preco2 = new Preco(32.90m);
            var transmissaoUnica2 = new TransmissaoDupla();
            var transformadorConteudo2 = new HD();

            var assinatura2 = new Assinatura(preco2, transformadorConteudo2, transmissaoUnica2);
            var qualidadeConteudo2 = transformadorConteudo2.ObtenhaQualidade();

            Console.WriteLine("Valor da assinatura.....: " + assinatura2.ObtenhaPreco());
            Console.WriteLine("Tipo da assinatura......: " + qualidadeConteudo2.ObtenhaQualidade());
            assinatura2.PrepareNumeroTransmissoes();

            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("");


            // 3ª assinatura
            var preco3 = new Preco(45.90m);
            var transmissaoUnica3 = new TransmissaoQuadrupla();
            var transformadorConteudo3 = new UltraHD();

            var assinatura3 = new Assinatura(preco3, transformadorConteudo3, transmissaoUnica3);
            var qualidadeConteudo3 = transformadorConteudo3.ObtenhaQualidade();

            Console.WriteLine("Valor da assinatura.....: " + assinatura3.ObtenhaPreco());
            Console.WriteLine("Tipo da assinatura......: " + qualidadeConteudo3.ObtenhaQualidade());
            assinatura3.PrepareNumeroTransmissoes();

            Console.ReadKey();
        }
    }
}
