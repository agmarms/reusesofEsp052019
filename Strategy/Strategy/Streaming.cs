using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Streaming
    {
        private string _qualidade;

        public Streaming(String qualidade)
        {
            _qualidade = qualidade;
        }

        public string ObtenhaQualidade()
        {
            return _qualidade;
        }
    }
}
