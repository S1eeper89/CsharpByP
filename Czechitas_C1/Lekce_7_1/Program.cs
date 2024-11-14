namespace Lekce_7_1
{

    //https://dotnetfiddle.net/NaNaHg
    //https://dotnetfiddle.net/Bkn0YT



    internal class Program
    {
        static void Main(string[] args)
        {
            //BankovniUcet jirikuvUcet = new BankovniUcet();
            //jirikuvUcet.VypisInfo();

            //jirikuvUcet.JmenoMajitele = "Jirik";
            //jirikuvUcet.VypisInfo();

            //jirikuvUcet.CisloUctu = "123456/0100";
            //jirikuvUcet.VypisInfo();

            //jirikuvUcet.Zustatek += 5000;
            //jirikuvUcet.VypisInfo();

            BankovniUcet marketyUcet = new BankovniUcet("Marketa", "0000002/0100");
            marketyUcet.VypisInfo();

            marketyUcet.Zustatek() += 3000;

        }
    }

    public class BankovniUcet
    {
        public string CisloUctu;
        public double Zustatek;
        public string JmenoMajitele;
        public BankovniUcet()
        {
            Zustatek = 500;
        }

        //public BankovniUcet()
        //{
        //    CisloUctu = "0000001/0100";
        //}

        public BankovniUcet(string jmenoMajitele, string cisloUctu)
        {
            jmenoMajitele = jmenoMajitele;
        }
        public double VlozPenize(double castka)
        {
            Zustatek += castka;
            return Zustatek;
        }
        public BankovniUcet NeKonstruktor()
        {
            return this;
        }

        public void VypisInfo ()
        {
            Console.WriteLine($"Ucet s cislem {CisloUctu} vlastneny {JmenoMajitele} se zustatkem {Zustatek}");
        }

        

    }

}
