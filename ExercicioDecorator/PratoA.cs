using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioDecorator
{
    public class PratoA : IPrato
    {
        public decimal ObtenhaPreco()
        {
            return 10m;
        }
    }
}
