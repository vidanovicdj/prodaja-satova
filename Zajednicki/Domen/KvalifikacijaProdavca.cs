using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class KvalifikacijaProdavca : IEntity
    {
        public int IdKvalifikacije { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public string Institucija { get; set; }
        public Prodavac Prodavac { get; set; }
        public Sertifikat Sertifikat { get; set; }
        public string NazivTabele => "KvalifikacijaProdavca";

        public string Vrednosti => $"('{DatumZavrsetka}','{Institucija}',{Prodavac.IdProdavca},{Sertifikat.IdSertifikata})";

        public string Uslov => $"idKvalifikacija={IdKvalifikacije}";

        public string UslovBezAlijasa => $"idKvalifikacija={IdKvalifikacije}";

        public string Output => "idKvalifikacije";

        public string Kriterijum => "";

        public string JoinUslov => "kp JOIN Sertifikat s ON (kp.idSertifikata = s.idSertifikata) JOIN p ON (kp.idProdavca = p.idProdavca)";

        public string UpdateUslov => $"datumZavrsetka='{DatumZavrsetka}', institucija='{Institucija}', idProdavca={Prodavac.IdProdavca}, idSertifikata={Sertifikat.IdSertifikata}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new KvalifikacijaProdavca
            {
                IdKvalifikacije = (int)citac["idKvalifikacije"],
                DatumZavrsetka = (DateTime)citac["datumZavrsetka"],
                Institucija = (string)citac["institucija"],
                Prodavac = new Prodavac
                {
                    IdProdavca = (int)citac["idProdavca"],
                    ImeProdavca = (string)citac["imeProdavca"],
                    PrezimeProdavca = (string)citac["prezimeProdavca"],
                    DatumZaposlenja = (DateTime)citac["datumZaposlenja"],
                    KorisnickoIme = (string)citac["korisnickoIme"],
                    Lozinka = (string)citac["lozinka"]
                },
                Sertifikat = new Sertifikat
                {
                    IdSertifikata = (int)citac["idSertifikata"],
                    NazivSertifikata = (string)citac["nazivSertifikata"]
                }
            };
        }
    }
}
