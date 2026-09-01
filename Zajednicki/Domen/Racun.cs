using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Racun : IEntity
    {
        public int IdRacuna { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public double ProcenatPopusta { get; set; }
        public double IznosPunaCena { get; set; }
        public double IznosSaPopustom { get; set; }
        public NacinPlacanja NacinPlacanja { get; set; }
        public Prodavac Prodavac { get; set; }
        public Klijent Klijent { get; set; }

        public List<StavkaRacuna> Stavke { get; set; }
        public List<StavkaRacuna> StavkeZaBrisanje { get; set; }
        public string NazivTabele => "Racun";

        public string Vrednosti => 
            $"('{DatumIzdavanja:yyyy-MM-dd}'," +
            $"{ProcenatPopusta.ToString(CultureInfo.InvariantCulture)}," +
            $"{IznosPunaCena.ToString(CultureInfo.InvariantCulture)}," +
            $"{IznosSaPopustom.ToString(CultureInfo.InvariantCulture)}," +
            $"'{NacinPlacanja}', " +
            $"{Prodavac?.IdProdavca ?? 0}, " +
            $"{Klijent?.IdKlijenta ?? 0})";

        public string Uslov => $"idRacuna={IdRacuna}";

        public string UslovBezAlijasa => $"idRacuna={IdRacuna}";

        public string Output => "idRacuna";

        public string Kriterijum => $" k.imeKlijenta LIKE '%{Klijent.ImeKlijenta}%' OR k.prezimeKlijenta LIKE '%{Klijent.PrezimeKlijenta}%'";

        public string JoinUslov => " r JOIN Prodavac p ON (r.idProdavca=p.idProdavca) JOIN Klijent k ON (r.idKlijenta=k.idKlijenta)";

        public string UpdateUslov => 
            $"datumIzdavanja='{DatumIzdavanja:yyyy-MM-dd}'," +
            $"procenatPopusta={ProcenatPopusta.ToString(CultureInfo.InvariantCulture)}," +
            $"iznosPunaCena={IznosPunaCena.ToString(CultureInfo.InvariantCulture)}," +
            $"iznosSaPopustom={IznosSaPopustom.ToString(CultureInfo.InvariantCulture)}," +
            $"nacinPlacanja='{NacinPlacanja}', " +
            $"idProdavca={Prodavac?.IdProdavca ?? 0}, idKlijenta={Klijent?.IdKlijenta ?? 0}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new Racun
            {
                IdRacuna = (int)citac["idRacuna"],
                DatumIzdavanja = (DateTime)citac["datumIzdavanja"],
                ProcenatPopusta = (double)citac["procenatPopusta"],
                IznosPunaCena = (double)citac["iznosPunaCena"],
                IznosSaPopustom = (double)citac["iznosSaPopustom"],
                NacinPlacanja = Enum.Parse<NacinPlacanja>((string)citac["nacinPlacanja"]),
                Prodavac = new Prodavac
                {
                    IdProdavca = (int)citac["idProdavca"],
                    ImeProdavca = (string)citac["imeProdavca"],
                    PrezimeProdavca = (string)citac["prezimeProdavca"],
                    DatumZaposlenja = (DateTime)citac["datumZaposlenja"],
                    KorisnickoIme = (string)citac["korisnickoIme"],
                    Lozinka = (string)citac["lozinka"]
                },
                Klijent = new Klijent
                {
                    IdKlijenta = (int)citac["idKlijenta"],
                    ImeKlijenta = (string)citac["imeKlijenta"],
                    PrezimeKlijenta = (string)citac["prezimeKlijenta"],
                    BrojTelefona = (string)citac["brojTelefona"],
                    EmailKlijenta = (string)citac["emailKlijenta"]
                }
            };
        }
    }
}
