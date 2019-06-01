using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Simples : ITransformadorConteudo
    {
        public Streaming ObtenhaQualidade()
        {
            return new Streaming("Plano Básico - Qualidade: Simples");
        }
    }
}
