using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class Besta : Veiculo
    {
        public override void ExibaNome()
        {
            Console.WriteLine("Criou o veículo Besta");
        }
    }
}
