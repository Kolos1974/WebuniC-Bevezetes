namespace Valasztasok
{
    public class Valaszto
    {
        public string Nev { get; set; }

        public bool Noe { get; set; }

        public int Szev { get; set; }

        public string Varos { get; set; }


        public override string ToString()
        {
            return $"{Nev} ({Szev}) _ {Varos}";
        }
    }
}
