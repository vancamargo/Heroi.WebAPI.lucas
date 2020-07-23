using H.Domain.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi.Dominio.Interface
{
   public interface IHeroi
    {
        public Herois Get(int codigo);
        public IEnumerable<Herois> Get();
        public bool Put(int codigo, Herois heroi);

        public Herois Post(Herois heroi);
        public bool Delete(int codigo);
        IEnumerable<Herois> GetPorBatalha(int codBatalha);
    }
}
