using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public abstract class FabricaDeVeiculoAbstrata
    {
        public abstract Veiculo CrieVeiculo(string clima, int qtdePessoas, string combustivel);
    }
}