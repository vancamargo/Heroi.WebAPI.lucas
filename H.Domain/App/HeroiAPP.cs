using Heroi.Dominio.Interface;
using System;
using Heroi.Dominio.Model;
using System.Collections.Generic;
using System.Text;
using H.Domain.Model;

namespace Heroi.Dominio.App
{
    public class HeroiAPP : IHeroi
    {
        public bool Delete(int codigo)
        {
            throw new NotImplementedException();
        }

        public Herois Get(int codigo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Herois> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Herois> GetPorBatalha(int codBatalha)
        {
            throw new NotImplementedException();
        }

        public Herois Post(Herois herois)
        {
            throw new NotImplementedException();
        }

        public bool Put(int codigo, Herois heroi)
        {
            throw new NotImplementedException();
        }
    }
}
