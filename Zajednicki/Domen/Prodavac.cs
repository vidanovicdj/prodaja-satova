using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Prodavac : IEntity
    {
        public int IdProdavca { get; set; }
        public string ImeProdavca { get; set; }
        public string PrezimeProdavca { get; set; }
        public DateOnly DatumZaposlenja { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public string PunoIme => $"{ImeProdavca} {PrezimeProdavca}";

        public string NazivTabele => "Prodavac";

        public string Vrednosti => $"('{ImeProdavca}', '{PrezimeProdavca}', '{DatumZaposlenja}', '{KorisnickoIme}', '{Lozinka}')";

        public string Uslov => $"idProdavca={IdProdavca}";

        public string UslovBezAlijasa => $"idProdavca={IdProdavca}";

        public string Output => "idProdavca";

        public string Kriterijum => " p.imeProdavca like";

        public string JoinUslov => "";

        public string UpdateUslov => $"imeProdavca='{ImeProdavca}', prezimeProdavca='{PrezimeProdavca}', datumZaposlenja='{DatumZaposlenja}', korisnickoIme='{KorisnickoIme}', lozinka='{Lozinka}'";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new Prodavac
            {
                IdProdavca = (int)citac["idProdavca"],
                ImeProdavca = (string)citac["imeProdavca"],
                PrezimeProdavca = (string)citac["prezimeProdavca"],
                DatumZaposlenja = (DateOnly)citac["datumZaposlenja"],
                KorisnickoIme = (string)citac["korisnickoIme"],
                Lozinka = (string)citac["lozinka"]
            };
        }
        public override string ToString()
        {
            return PunoIme;
        }
    }
}
