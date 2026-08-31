using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.KlijentSO
{
    public class IzmeniKlijentaSO : OpstaSO
    {
        public bool Rezultat { get; private set; }
        private Klijent klijent;

        public IzmeniKlijentaSO(Klijent klijent)
        {
            this.klijent = klijent;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            if(repository.Izmeni(klijent) == 0)
            {
                Rezultat = false;
                return;
            }
            Rezultat = true;
        }
    }
}
