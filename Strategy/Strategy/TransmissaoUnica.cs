using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class TransmissaoUnica : IPreparadorNumeroTransmissoes
    {
        public int ObtenhaNumeroDeTransmissoes()
        {
           return 1;
        }
    }
}
