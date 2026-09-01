using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.RacunSO
{
    public class VratiListuSvihRacunaSO : OpstaSO
    {
        public List<Racun> Rezultat { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.VratiSve(new Racun()).OfType<Racun>().ToList();
        }
    }
}
