using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class TransmissaoQuadrupla : IPreparadorNumeroTransmissoes
    {
        public int ObtenhaNumeroDeTransmissoes()
        {
            return 4;
        }
    }
}
