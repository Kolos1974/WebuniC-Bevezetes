

namespace Barataim
{
    public class Barat
    {
        public int Tel { get; set; }

        public string Nev { get; set; }

        public string Cim { get; set; }


        public override string ToString()
        {
            return $"Név: {Nev} --- Cim: {Cim} --- Telefonszám {Tel}";
        }
    }
}
