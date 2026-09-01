using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.RacunSO
{
    public class NadjiRacuneSO : OpstaSO
    {
        public List<Racun> Rezultat { get; private set; }
        public NadjiRacuneSO() { }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.Pretraga(entity).OfType<Racun>().ToList();
        }
    }
}
