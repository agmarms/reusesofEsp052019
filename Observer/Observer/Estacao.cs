using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Estacao : EstacaoAbstrata
    {
        private List<InteressadoAbstrata> _interessados = new List<InteressadoAbstrata>();

        private string _temperatura { get; set; }
        private string _pressao { get; set; }
        private string _umidade { get; set; }

        public void AtualizeInformacoes(string temperatura, string pressao, string umidade)
        {
            _temperatura = temperatura;
            _pressao = pressao;
            _umidade = umidade;

            Notifique();
        }

        public override void Assine(InteressadoAbstrata interessado)
        {
            _interessados.Add(interessado);
        }

        public override void CanceleAssinatura(InteressadoAbstrata interessado)
        {
            _interessados.Remove(interessado);
        }

        public override void Notifique()
        {
            foreach (var interessado in _interessados)
            {
                interessado.Atualize();
            }
        }

        public string ObtenhaInformacoes()
        {
            return _temperatura + " - " + _pressao + " - " + _umidade;
        }
    }
}
