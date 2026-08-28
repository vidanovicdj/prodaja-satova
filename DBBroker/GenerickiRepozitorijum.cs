using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace DBBroker
{
    public class GenerickiRepozitorijum : IGenerickiRepozitorijum
    {
        private Broker broker = new Broker();
        public void Commit()
        {
            broker.Commit();
        }

        public int Izbrisi(IEntity objekat)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"delete from {objekat.NazivTabele} where {objekat.UslovBezAlijasa}";
            return command.ExecuteNonQuery();
        }

        public int Izmeni(IEntity objekat)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"update {objekat.NazivTabele} set {objekat.UpdateUslov} where {objekat.UslovBezAlijasa}";
            return command.ExecuteNonQuery();
        }

        public void OtvoriKonekciju()
        {
            broker.OpenConnection();
        }

        public List<IEntity> Pretraga(IEntity objekat)
        {
            List<IEntity> lista = new List<IEntity>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {objekat.NazivTabele} {objekat.JoinUslov} where ({objekat.Kriterijum})";
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                   lista.Add(objekat.ProcitajObjekat(reader));
                }
            }

            return lista;
        }

        public void RollBack()
        {
            broker.Rollback();
        }

        public int Sacuvaj(IEntity objekat)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"insert into {objekat.NazivTabele} output inserted.{objekat.Output} values {objekat.Vrednosti}";
            return (int) command.ExecuteScalar();
        }

        public IEntity VratiJedan(IEntity objekat)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {objekat.NazivTabele} {objekat.JoinUslov} where {objekat.Uslov}";
            IEntity result;
            using(SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return null;
                }
                result = objekat.ProcitajObjekat(reader);
            }

            return result;
        }

        public List<IEntity> VratiSve(IEntity objekat)
        {
            List<IEntity> lista = new List<IEntity>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {objekat.NazivTabele} {objekat.JoinUslov}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    lista.Add(objekat.ProcitajObjekat(reader));
                }
            }

            return lista;
        }

        public List<IEntity> VratiSveZaNekog(IEntity objekat)
        {
            List<IEntity> lista = new List<IEntity>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {objekat.NazivTabele} {objekat.JoinUslov} where {objekat.Uslov}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(objekat.ProcitajObjekat(reader));
                }
            }

            return lista;
        }

        public void ZapocniTransakciju()
        {
            broker.BeginTransaction();
        }

        public void ZatvoriKonekciju()
        {
            broker.CloseConnection();
        }
    }
}
