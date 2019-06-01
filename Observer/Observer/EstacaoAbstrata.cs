using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    /// <summary>
    /// Subject
    /// </summary>
    public abstract class EstacaoAbstrata
    {
        public abstract void Assine(InteressadoAbstrata interessado);

        public abstract void CanceleAssinatura(InteressadoAbstrata interessado);

        public abstract void Notifique();
    }
}
