using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Klijent.Sesija
{
    public class Session
    {
        private static Session instance;

        private Session()
        {
            
        }

        public static Session Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        public Prodavac TrenutnoPrijavljeni { get; set; }
    }
}
