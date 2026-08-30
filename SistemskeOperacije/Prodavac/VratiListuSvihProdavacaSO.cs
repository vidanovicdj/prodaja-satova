using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.ProdavacSO
{
    public class VratiListuSvihProdavacaSO : OpstaSO
    {
        public List<Prodavac> Rezultat { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            var prodavci = repository.VratiSve(new Prodavac());
            Rezultat = prodavci?.OfType<Prodavac>().ToList() ?? new List<Prodavac>();
        }
    }
}
