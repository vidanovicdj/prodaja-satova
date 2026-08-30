using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.KlijentSO
{
    public class VratiListuSvihKlijenataSO : OpstaSO
    {
        public List<Klijent> Rezultat { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.VratiSve(new Klijent()).OfType<Klijent>().ToList();
        }
    }
}
