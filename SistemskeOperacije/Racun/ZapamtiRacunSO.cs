using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.RacunSO
{
    public class ZapamtiRacunSO : OpstaSO
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Racun racun = (Racun)entity;

            int id = repository.Sacuvaj(racun);
            racun.IdRacuna = id;

            foreach(var stavka in racun.Stavke)
            {
                stavka.IdRacuna = racun.IdRacuna;
                repository.Sacuvaj(stavka);
                repository.Izmeni(stavka.Sat);
            }
        }
    }
}
