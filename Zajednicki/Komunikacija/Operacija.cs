using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public enum Operacija
    {
        // prodavac
        Login,
        VratiListuSvihProdavaca,
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
        IzbrisiKlijenta,
        // sertifikat
        ZapamtiSertifikat,
        // racun
        ZapamtiRacun,
        VratiListuSvihRacuna,
        NadjiRacune,
        UcitajRacune,
        IzmeniRacun
    }
}
