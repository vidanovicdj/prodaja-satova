using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class TipKlijenta : IEntity
    {
        public int IdTipaKlijenta { get; set; }
        public string RangKlijenta { get; set; }
        public double Pogodnost { get; set; }
        public string NazivTabele => "TipKlijenta";

        public string Vrednosti => $"('{RangKlijenta}',{Pogodnost})";

        public string Uslov => $"idTipaKlijenta={IdTipaKlijenta}";

        public string UslovBezAlijasa => $"idTipaKlijenta={IdTipaKlijenta}";

        public string Output => "idTipaKlijenta";

        public string Kriterijum => "";

        public string JoinUslov => "";

        public string UpdateUslov => $"rangKlijenta='{RangKlijenta}', pogodnost={Pogodnost}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new TipKlijenta
            {
                IdTipaKlijenta = (int)citac["idTipaKlijenta"],
                RangKlijenta = (string)citac["rangKlijenta"],
                Pogodnost = (double)citac["pogodnost"]
            };
        }
        public override string ToString()
        {
            return $"{RangKlijenta} ({Pogodnost}%)";
        }
    }
}
