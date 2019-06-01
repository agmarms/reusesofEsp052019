using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var estacao = new Estacao();

            estacao.Assine(new CampusUniversitario(estacao)); 
            estacao.Assine(new ClimaTempo(estacao));
            estacao.Assine(new Inmet(estacao));

            estacao.AtualizeInformacoes("T1", "P1", "U1");
            Console.WriteLine("----------------------------------------------------------------------------");
            estacao.AtualizeInformacoes("T2", "P2", "U2");
            Console.WriteLine("----------------------------------------------------------------------------");
            estacao.AtualizeInformacoes("T3", "P3", "U3");

            Console.ReadKey();
        }
    }
}
