using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.SatSO
{
    public class VratiListuSvihSatovaSO : OpstaSO
    {
        public List<Sat> Rezultat { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            var satovi = repository.VratiSve(new Sat());
            Rezultat = satovi?.OfType<Sat>().ToList() ?? new List<Sat>();
        }
    }
}
