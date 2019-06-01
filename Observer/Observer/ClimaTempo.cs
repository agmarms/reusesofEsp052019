using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class ClimaTempo : InteressadoAbstrata
    {
        private Estacao _estacao;

        public ClimaTempo(Estacao estacao)
        {
            _estacao = estacao;
        }

        public override void Atualize()
        {
            Console.WriteLine("Clima Tempo.........: " + _estacao.ObtenhaInformacoes());
        }
    }
}
