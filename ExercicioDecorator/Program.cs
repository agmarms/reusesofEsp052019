using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrato meuPrato = new PratoA();
            meuPrato = new AdicionalOvo(meuPrato);
            meuPrato = new AdicionalOvo(meuPrato);
            meuPrato = new AdicionalCebola(meuPrato);


            Console.WriteLine("Valor do prato " + meuPrato.ObtenhaPreco());

            Console.ReadKey();
        }
    }
}
