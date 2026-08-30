using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.TipKlijentaSO
{
    public class VratiListuSvihTipovaKlijenataSO : OpstaSO
    {
        public List<TipKlijenta> Rezultat {  get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            var tipoviKlijenata = repository.VratiSve(new TipKlijenta());
            Rezultat = tipoviKlijenata?.OfType<TipKlijenta>().ToList() ?? new List<TipKlijenta>();
        }
    }
}
