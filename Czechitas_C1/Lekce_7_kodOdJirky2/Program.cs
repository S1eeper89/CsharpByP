namespace Lekce_7_kodOdJirky2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankovniUcet.VypisPocetUctu();

            BankovniUcet marketyUcet = new BankovniUcet("Marketa");
            marketyUcet.VypisInfo();

            marketyUcet.VlozPenize(3333);
            marketyUcet.VypisInfo();

            BankovniUcet lubosuvUcet = new BankovniUcet("Lubos");
            lubosuvUcet.VypisInfo();

            lubosuvUcet.VlozPenize(4444);
            lubosuvUcet.VypisInfo();

            BankovniUcet.VypisPocetUctu();
            //BankovniUcet.PocetUctu = 5;

            BankovniUcet honzuvUcet = new BankovniUcet("Honza");
            honzuvUcet.VypisInfo();

            honzuvUcet.VlozPenize(6666);
            honzuvUcet.VypisInfo();
            BankovniUcet.VypisPocetUctu();
        }
    }

    public class BankovniUcet
    {
        private static int PocetUctu;
        public static void VypisPocetUctu()
        {
            if (PocetUctu > 0)
            {
                Console.WriteLine($"Evidujeme {PocetUctu} uctu.");
            }
            else
            {
                Console.WriteLine("Neexistuje zadny ucet.");
            }
        }

        //--------------------------

        private string CisloUctu;
        private double Zustatek;
        private string JmenoMajitele;


        public BankovniUcet(string jmenoMajitele)
        {
            PocetUctu++;
            JmenoMajitele = jmenoMajitele;
            CisloUctu = $"0000000{PocetUctu}/0100";
            Zustatek = 1000;
        }


        public double VlozPenize(double castka)
        {
            Zustatek += castka;
            return Zustatek;
        }

        public double VyberPenize(double castka)
        {
            if (castka <= Zustatek)
            {
                Zustatek -= castka;
            }
            else
            {
                Zustatek = 0;
            }
            return Zustatek;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Ucet s cislem {CisloUctu} vlastneny {JmenoMajitele} se zustatkem {Zustatek}");
        }
    }
}