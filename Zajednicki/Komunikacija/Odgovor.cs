using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public class Odgovor
    {
        public bool Signal { get; set; } = true;
        public string Poruka { get; set; }
        public object Podaci { get; set; }
    }
}
