using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public interface IEntity
    {
        string NazivTabele { get; }
        string Vrednosti { get; }
        string Uslov { get; }
        string UslovBezAlijasa { get; }
        string Output { get; }
        string Kriterijum { get; }
        string JoinUslov { get; }
        string UpdateUslov { get; }

        IEntity ProcitajObjekat(SqlDataReader citac);
    }
}
