using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.KlijentSO
{
    public class UcitajKlijenteSO : OpstaSO
    {
        public Klijent Rezultat { get; private set; }
        private Klijent klijent;

        public UcitajKlijenteSO(Klijent klijent)
        {
            this.klijent = klijent;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = (Klijent)repository.VratiJedan(klijent);
        }
    }
}
