using SistemskeOperacije;
using SistemskeOperacije.ProdavacSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server
{
    public class Kontroler
    {
        private static Kontroler instance;
        private static object _lock = new object();

        private Kontroler() { }
        public static Kontroler Instance
        {
            get 
            {
                if(instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Kontroler();
                        }
                    }
                }
                return instance; 
            }
        }

        public Prodavac Login(Prodavac p)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(p);
            return so.Result;
        }
    }
}
