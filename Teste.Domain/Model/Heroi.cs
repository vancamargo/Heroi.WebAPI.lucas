using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi.Dominio.Model
{
    public class Heroi
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public virtual Batalha CodigoBatalhaNavigation { get; set; }//n para n com batalha
    }
}
