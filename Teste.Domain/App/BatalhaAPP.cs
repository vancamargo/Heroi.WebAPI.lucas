using Heroi.Dominio.Interface;
using Heroi.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi.Dominio.App
{
    public class BatalhaAPP : IBatalha
    {
        public bool Delete(int codigo)
        {
            throw new NotImplementedException();
        }

        public Batalha Get(int codigo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Batalha> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Batalha> GetPorHeroi(int codHeroi)
        {
            throw new NotImplementedException();
        }

        public Batalha Post(Batalha batalha)
        {
            throw new NotImplementedException();
        }

        public bool Put(int codigo, Batalha batalha)
        {
            throw new NotImplementedException();
        }
    }
}
