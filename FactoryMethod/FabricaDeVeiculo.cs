using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class FabricaDeVeiculo : FabricaDeVeiculoAbstrata
    {
        public override Veiculo CrieVeiculo(string clima, int qtdePessoas, string combustivel)
        {
            if (qtdePessoas == 2 || combustivel == "Eletricidade")
                {
                    return new Tesla();
                }
            else if (qtdePessoas == 5)
                {
                    if (clima == "Sol" && combustivel == "Alcool") return new Escort();
                    return new Opala();
                }
            return new Besta();
        }
    }
}
