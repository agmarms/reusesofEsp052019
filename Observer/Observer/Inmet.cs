using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Inmet : InteressadoAbstrata
    {
        private Estacao _estacao;

        public Inmet(Estacao estacao)
        {
            _estacao = estacao;
        }

        public override void Atualize()
        {
            Console.WriteLine("Inmet...............: " + _estacao.ObtenhaInformacoes());
        }
    }
}
