using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.SatSO
{
    public class ZapamtiSatSO : OpstaSO
    {
        private Sat sat;
        public ZapamtiSatSO(Sat sat)
        {
            this.sat = sat;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Sacuvaj(entity);
        }
    }
}
