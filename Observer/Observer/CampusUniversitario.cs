using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class CampusUniversitario : InteressadoAbstrata
    {
        private Estacao _estacao;

        public CampusUniversitario(Estacao estacao)
        {
            _estacao = estacao;
        }

        public override void Atualize()
        {
            Console.WriteLine("Campus Universitário: " + _estacao.ObtenhaInformacoes());
        }
    }
}
