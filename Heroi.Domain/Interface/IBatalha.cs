using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi.Dominio.Interface
{
  public  interface IBatalha
    {
        public Batalha Get(int codigo);
        public IEnumerable<Batalha> Get();
        public bool Put(int codigo, Batalha batalha);

        public Batalha Post(Batalha batalha);
        public bool Delete(int codigo);
        IEnumerable<Batalha> GetPorHeroi(int codHeroi);
    }
}
