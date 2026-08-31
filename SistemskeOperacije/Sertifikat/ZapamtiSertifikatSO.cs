using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.SertifikatSO
{
    public class ZapamtiSertifikatSO : OpstaSO
    {
        private readonly Sertifikat sertifikat;

        public ZapamtiSertifikatSO(Sertifikat sertifikat)
        {
            this.sertifikat = sertifikat;
        }
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Sacuvaj(entity);
        }
    }
}
