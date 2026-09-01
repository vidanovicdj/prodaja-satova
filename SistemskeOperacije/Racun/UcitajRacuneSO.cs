using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.RacunSO
{
    public class UcitajRacuneSO : OpstaSO
    {
        public Racun Rezultat { get; private set; }
        private Racun racun;

        public UcitajRacuneSO(Racun r)
        {
            this.racun = r;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = (Racun)repository.VratiJedan(racun);
            StavkaRacuna sr = new StavkaRacuna
            {
                IdRacuna = Rezultat.IdRacuna
            };
            Rezultat.Stavke = repository.VratiSveZaNekog(sr).OfType<StavkaRacuna>().ToList();
        }
    }
}
