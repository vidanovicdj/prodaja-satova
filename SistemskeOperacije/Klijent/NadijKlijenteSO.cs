using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.KlijentSO
{
    public class NadijKlijenteSO : OpstaSO
    {
        public List<Klijent> Rezultat { get; private set; }
        public NadijKlijenteSO() { }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.Pretraga(entity).OfType<Klijent>().ToList();
        }
    }
}
