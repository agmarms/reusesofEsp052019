using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioDecorator
{
    public class PratoB : IPrato
    {
        public decimal ObtenhaPreco()
        {
            return 12m;
        }
    }
}
