using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.Exceptions
{
    [Serializable]
    internal class EmptyStavkeException : Exception
    {
        public EmptyStavkeException() : base("Rezervacija mora imati bar jednu stavku.") { }
    }
}
