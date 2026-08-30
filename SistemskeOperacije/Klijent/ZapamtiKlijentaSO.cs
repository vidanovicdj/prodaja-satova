using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.KlijentSO
{
    public class ZapamtiKlijentaSO : OpstaSO
    {
        private Klijent klijent;
        public ZapamtiKlijentaSO(Klijent klijent)
        {
            this.klijent = klijent;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Sacuvaj(entity);
        }
    }
}
