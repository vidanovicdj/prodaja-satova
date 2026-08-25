using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Sertifikat : IEntity
    {
        public int IdSertifikata { get; set; }
        public string NazivSertifikata { get; set; }

        public string NazivTabele => "Sertifikat";

        public string Vrednosti => $"('{NazivSertifikata}')";

        public string Uslov => $"idSertifikata={IdSertifikata}";

        public string UslovBezAlijasa => $"idSertifikata={IdSertifikata}";

        public string Output => "idSertifikata";

        public string Kriterijum => " nazivSertifikata like";

        public string JoinUslov => "s LEFT JOIN KvalifikacijaProdavca kp ON (s.idSertifikata = kp.idSertifikata)";

        public string UpdateUslov => $"nazivSertifikate = '{NazivSertifikata}'";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new Sertifikat
            {
                IdSertifikata = (int)citac["idSertifikata"],
                NazivSertifikata = (string)citac["nazivSertifikata"]
            };
        }

        public override string ToString()
        {
            return NazivSertifikata;
        }
    }
}
