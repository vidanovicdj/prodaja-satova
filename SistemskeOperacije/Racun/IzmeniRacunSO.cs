using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.RacunSO
{
    public class IzmeniRacunSO : OpstaSO
    {
        private Racun racun;
        public bool Rezultat { get; private set; }

        public IzmeniRacunSO(Racun r)
        {
            racun = r;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            if(repository.Izmeni(racun) == 0)
            {
                Rezultat = false;
                return;
            }

            if(racun.StavkeZaBrisanje != null && racun.StavkeZaBrisanje.Count > 0)
            {
                foreach(var stavkaZaBrisanje in racun.StavkeZaBrisanje)
                {
                    repository.Izmeni(stavkaZaBrisanje.Sat);
                    if (stavkaZaBrisanje.RbStavkeRacuna > 0)
                    {
                        //repository.Izmeni(stavkaZaBrisanje.Sat);
                        repository.Izbrisi(stavkaZaBrisanje);
                    }
                }
            }

            foreach(var stavka in racun.Stavke)
            {
                if(stavka.RbStavkeRacuna == 0)
                {
                    repository.Sacuvaj(stavka);
                    repository.Izmeni(stavka.Sat);
                }
            }

            Rezultat = true;
        }
    }
}
