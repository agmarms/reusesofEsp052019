using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioDecorator
{
    public class AdicionalOvo : DecoratorAdicionalAbstrata
    {
        public AdicionalOvo(IPrato prato) : base(prato) { }

        public override decimal ObtenhaPreco()
        {
            return _prato.ObtenhaPreco() + 1.50m;
        }
    }
}
