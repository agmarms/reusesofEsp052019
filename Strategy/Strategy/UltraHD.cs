using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class UltraHD : ITransformadorConteudo
    {
        public Streaming ObtenhaQualidade()
        {
            return new Streaming("Plano Premium - Qualidade: UltraHD");
        }
    }
}
