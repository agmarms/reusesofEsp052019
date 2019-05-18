using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioDecorator
{
    public class AdicionalCebola : DecoratorAdicionalAbstrata
    {
        public AdicionalCebola(IPrato prato) : base(prato) { }

        public override decimal ObtenhaPreco()
        {
            return _prato.ObtenhaPreco() + 1m;
        }
    }
}
