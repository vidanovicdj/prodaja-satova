using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace DBBroker
{
    public interface IGenerickiRepozitorijum
    {
        int Sacuvaj(IEntity objekat);
        int Izmeni(IEntity objekat);
        int Izbrisi(IEntity objekat);
        IEntity VratiJedan(IEntity objekat);
        List<IEntity> VratiSve(IEntity objekat);
        List<IEntity> Pretraga(IEntity objekat);
        List<IEntity> VratiSveZaNekog(IEntity objekat);
        void OtvoriKonekciju();
        void ZatvoriKonekciju();
        void ZapocniTransakciju();
        void Commit();
        void RollBack();
    }
}
