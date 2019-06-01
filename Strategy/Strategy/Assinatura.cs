using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Assinatura
    {
        private IPreco _preco;
        private ITransformadorConteudo _transformadorDeConteudo;
        private IPreparadorNumeroTransmissoes _preparadorNumeroTransmissoes;

        public Assinatura(IPreco preco, ITransformadorConteudo transformadorDeConteudo, IPreparadorNumeroTransmissoes preparadorNumeroTransmissoes)
        {
            _preco = preco;
            _transformadorDeConteudo = transformadorDeConteudo;
            _preparadorNumeroTransmissoes = preparadorNumeroTransmissoes;
        }

        public decimal ObtenhaPreco()
        {
            return _preco.ObtenhaPreco();
        }

        public Streaming ObtenhaQualidadeConteudo()
        {
            return _transformadorDeConteudo.ObtenhaQualidade();
        }

        public void PrepareNumeroTransmissoes()
        {
            Console.WriteLine("Transmissões simultâneas: " + _preparadorNumeroTransmissoes.ObtenhaNumeroDeTransmissoes());
        }
    }
}
