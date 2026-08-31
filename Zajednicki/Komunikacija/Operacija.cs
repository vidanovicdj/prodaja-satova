using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public enum Operacija
    {
        Login,
        Kraj,
        // sat
        ZapamtiSat,
        VratiListuSvihSatova,
        // tip klijenta
        VratiSveTipoveKlijenata,
        // klijent
        ZapamtiKlijenta,
        VratiListuSvihKlijenata,
        NadjiKlijente,
        UcitajKlijente,
        IzmeniKlijenta,
        IzbrisiKlijenta
    }
}
