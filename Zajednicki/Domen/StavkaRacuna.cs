using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class StavkaRacuna : IEntity
    {
        public int RbStavkeRacuna { get; set; }
        public int Kolicina { get; set; }
        public double JedinicnaCena { get; set; }
        public double CenaStavke { get; set; }
        public int IdRacuna { get; set; }
        public Sat Sat { get; set; }
        public string NazivTabele => "StavkaRacuna";

        public string Vrednosti
        {
            get
            {
                if (Sat == null || Sat.IdSata == 0)
                    throw new InvalidOperationException("Stavka mora ima validan sat sa IdSata");

                return $"({IdRacuna}, {Sat.IdSata}, {Kolicina}, {JedinicnaCena}, {CenaStavke})";
            }
        }

        public string Uslov => $"sr.idRacuna = {IdRacuna}";

        public string UslovBezAlijasa => $"idRacuna={IdRacuna} AND rbStavkeRacuna={RbStavkeRacuna}";

        public string Output => "rbStavkeRacuna";

        public string Kriterijum => "";

        public string JoinUslov => " sr JOIN Racun r ON (sr.idRacuna=r.idRacuna) JOIN Sat s ON (sr.idSata=s.idSata)";

        public string UpdateUslov => $"kolicina={Kolicina}, jedinicnaCena={JedinicnaCena}, cenaStavke={CenaStavke}, idSata={Sat?.IdSata ?? 0}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new StavkaRacuna
            {
                RbStavkeRacuna = (int)citac["rbStavkeRacuna"],
                IdRacuna = (int)citac["idRacuna"],
                Kolicina = (int)citac["kolicina"],
                JedinicnaCena = (double)citac["jedinicnaCena"],
                CenaStavke = (double)citac["cenaStavke"],
                Sat = new Sat
                {
                    IdSata = (int)citac["idSata"],
                    Brend = (string)citac["brend"],
                    NazivModela = (string)citac["nazivModela"],
                    SifraModela = (string)citac["sifraModela"],
                    TipMehanizma = (TipMehanizma)citac["tipMehanizma"],
                    DimenzijeKucista = (double)citac["dimenzijeKucista"],
                    Staklo = (Staklo)citac["staklo"],
                    Materijal = (string)citac["materijal"],
                    CenaSata = (double)citac["cenaSata"],
                    KolicinaNaStanju = (int)citac["kolicinaNaStanju"]
                }
            };
        }
    }
}
