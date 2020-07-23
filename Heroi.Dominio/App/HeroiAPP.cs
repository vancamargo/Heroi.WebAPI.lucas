using Heroi.Dominio.Interface;
using System;
using Heroi.Dominio.Model;
using System.Collections.Generic;
using System.Text;

namespace Heroi.Dominio.App
{
    public class HeroiAPP : IHeroi
    {
        public bool Delete(int codigo)
        {
            throw new NotImplementedException();
        }

        public Heroi Get(int codigo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Heroi> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Heroi> GetPorBatalha(int codBatalha)
        {
            throw new NotImplementedException();
        }

        public Heroi Post(Heroi heroi)
        {
            throw new NotImplementedException();
        }

        public bool Put(int codigo, Heroi heroi)
        {
            throw new NotImplementedException();
        }
    }
}
