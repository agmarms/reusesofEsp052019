using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class FabricaDeVeiculoCrise : FabricaDeVeiculoAbstrata
    {
        public override Veiculo CrieVeiculo(string clima, int qtdePessoas, string combustivel)
        {
            throw new NotImplementedException();
        }
    }
}
