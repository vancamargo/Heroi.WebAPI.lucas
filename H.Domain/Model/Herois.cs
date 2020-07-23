using Heroi.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace H.Domain.Model
{
    public class Herois
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public virtual Batalha CodigoBatalhaNavigation { get; set; }//n para n com batalha
    }
}
