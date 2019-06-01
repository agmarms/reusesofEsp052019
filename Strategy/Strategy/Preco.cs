using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Preco : IPreco
    {
        private decimal _preco;

        public Preco(decimal preco)
        {
            _preco = preco;
        }

        public decimal ObtenhaPreco()
        {
            return _preco;
        }
    }
}
