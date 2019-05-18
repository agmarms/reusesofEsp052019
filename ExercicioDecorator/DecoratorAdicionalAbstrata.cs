using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioDecorator
{
    public abstract class DecoratorAdicionalAbstrata : IPrato
    {
        protected IPrato _prato;

        protected DecoratorAdicionalAbstrata(IPrato prato)
        {
            _prato = prato;
        }

        public abstract decimal ObtenhaPreco();
    }
}
