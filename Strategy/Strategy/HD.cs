using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class HD : ITransformadorConteudo
    {
        public Streaming ObtenhaQualidade()
        {
            return new Streaming("Plano Padrão - Qualidade: HD");
        }
    }
}
