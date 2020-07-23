using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi.Dominio.Interface
{
   public interface IHeroi
    {
        public Heroi Get(int codigo);
        public IEnumerable<Heroi> Get();
        public bool Put(int codigo, Heroi heroi);

        public Heroi Post(Heroi heroi);
        public bool Delete(int codigo);
        IEnumerable<Heroi> GetPorBatalha(int codBatalha);
    }
}
