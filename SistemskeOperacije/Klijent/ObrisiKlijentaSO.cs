using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.KlijentSO
{
    public class ObrisiKlijentaSO : OpstaSO
    {
        public bool Rezultat { get; private set; }
        private Klijent klijent;

        public ObrisiKlijentaSO(Klijent klijent)
        {
            this.klijent = klijent;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            if(repository.Izbrisi(klijent) == 0)
            {
                Rezultat = false;
                return;
            }
            Rezultat = true;
        }
    }
}
