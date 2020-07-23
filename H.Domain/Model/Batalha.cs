using H.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi.Dominio.Model
{
   public class Batalha
    {
        public int Codigo { get; set; }
        public string Local { get; set; }
        public DateTime Date { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Herois> Herois { get; set; }//n para n com heroi
    }
}
