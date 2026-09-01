using Microsoft.Data.SqlClient;
using System;

namespace Zajednicki.Domen
{
    public class Sat : IEntity
    {
        public int IdSata { get; set; }
        public string Brend { get; set; }
        public string NazivModela { get; set; }
        public string SifraModela { get; set; }
        public TipMehanizma TipMehanizma { get; set; }
        public double DimenzijeKucista { get; set; }
        public Staklo Staklo { get; set; }
        public string Materijal { get; set; }
        public double CenaSata { get; set; }
        public int KolicinaNaStanju { get; set; }

        public string ModelSata => $"{Brend} {SifraModela}";

        public string NazivTabele => "Sat";

        public string Vrednosti => 
            $"('{Brend}', '{NazivModela}', '{SifraModela}', '{TipMehanizma}', {DimenzijeKucista}, '{Staklo}', '{Materijal}', {CenaSata}, {KolicinaNaStanju})";

        public string Uslov => $"idSata={IdSata}";

        public string UslovBezAlijasa => $"idSata={IdSata}";

        public string Output => "idSata";

        public string Kriterijum => "s.sifraModela like";

        public string JoinUslov => "";

        public string UpdateUslov => 
            $"brend='{Brend}', nazivModela='{NazivModela}', sifraModela='{SifraModela}', tipMehanizma='{TipMehanizma}', dimenzijeKucista={DimenzijeKucista}, staklo='{Staklo}', materijal='{Materijal}', cenaSata={CenaSata}, kolicinaNaStanju={KolicinaNaStanju}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new Sat
            {
                IdSata = (int)citac["idSata"],
                Brend = (string)citac["brend"],
                NazivModela = (string)citac["nazivModela"],
                SifraModela = (string)citac["sifraModela"],
                TipMehanizma = Enum.Parse<TipMehanizma>((string)citac["tipMehanizma"]),
                DimenzijeKucista = (double)citac["dimenzijeKucista"],
                Staklo = Enum.Parse<Staklo>((string)citac["staklo"]),
                Materijal = (string)citac["materijal"],
                CenaSata = (double)citac["cenaSata"],
                KolicinaNaStanju = (int)citac["kolicinaNaStanju"]
            };
        }

        public override string ToString()
        {
            return $"{Brend} {NazivModela}";
        }
    }
}
