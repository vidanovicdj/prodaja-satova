using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Klijent : IEntity
    {
        public int IdKlijenta { get; set; }
        public string ImeKlijenta { get; set; }
        public string PrezimeKlijenta { get; set; }
        public string BrojTelefona { get; set; }
        public string EmailKlijenta { get; set; }
        public TipKlijenta TipKlijenta { get; set; }
        public string PunoIme => ImeKlijenta + " " + PrezimeKlijenta;
        public string NazivTabele => "Klijent";

        public string Vrednosti => $"('{ImeKlijenta}', '{PrezimeKlijenta}', '{BrojTelefona}', '{EmailKlijenta}', {(TipKlijenta != null ? TipKlijenta.IdTipaKlijenta.ToString() : "NULL")})";

        public string Uslov => $"idKlijenta={IdKlijenta}";

        public string UslovBezAlijasa => $"idKlijenta={IdKlijenta}";

        public string Output => "idKlijenta";

        public string Kriterijum => $" emailKlijenta LIKE '{EmailKlijenta}'";

        public string JoinUslov => "JOIN TipKlijenta tk ON (Klijent.idTipaKlijenta = tk.idTipaKlijenta)";

        public string UpdateUslov => $"imeKlijenta='{ImeKlijenta}', prezimeKlijenta='{PrezimeKlijenta}', brojTelefona='{BrojTelefona}', emailKlijenta='{EmailKlijenta}', idTipaKlijenta={(TipKlijenta != null ? TipKlijenta.IdTipaKlijenta.ToString() : "NULL")}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new Klijent
            {
                IdKlijenta = (int)citac["idKlijenta"],
                ImeKlijenta = (string)citac["imeKlijenta"],
                PrezimeKlijenta = (string)citac["prezimeKlijenta"],
                BrojTelefona = (string)citac["brojTelefona"],
                EmailKlijenta = (string)citac["emailKlijenta"],
                TipKlijenta = new TipKlijenta
                {
                    IdTipaKlijenta = (int)citac["idTipaKlijenta"],
                    RangKlijenta = (string)citac["rangKlijenta"],
                    Pogodnost = (double)citac["pogodnost"]
                }
            };
        }
        public override string ToString()
        {
            return PunoIme;
        }
    }
}
