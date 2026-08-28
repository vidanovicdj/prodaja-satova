using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.ProdavacSO
{
    public class LoginSO : OpstaSO
    {
        public Prodavac Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Prodavac prodavac = (Prodavac)entity;

            foreach (Prodavac p in repository.VratiSve(new Prodavac()))
            {
                if (p.KorisnickoIme == prodavac.KorisnickoIme && p.Lozinka == prodavac.Lozinka)
                {
                    Result = p;
                    break;
                }
            }
        }
    }
}
