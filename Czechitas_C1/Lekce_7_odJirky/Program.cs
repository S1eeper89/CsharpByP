using System;

namespace Lekce7_KonstruktoryModifikatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankovniUcet jirkuvUcet = new BankovniUcet();
            //jirkuvUcet.VypisInfo();

            //jirkuvUcet.JmenoMajitele = "Jirik";
            //jirkuvUcet.VypisInfo();

            //jirkuvUcet.CisloUctu = "123465846/0100";
            //jirkuvUcet.VypisInfo();

            //jirkuvUcet.Zustatek += 5000;
            //jirkuvUcet.VypisInfo();

            //BankovniUcet marketyUcet = new BankovniUcet("Marketa", "000002/0100");
            //marketyUcet.VypisInfo();

            //marketyUcet.Zustatek += 3333;
            //marketyUcet.VypisInfo();

            //marketyUcet.JmenoMajitele = jirkuvUcet.JmenoMajitele;
            //marketyUcet.VypisInfo();

            BankovniUcet lubosuvUcet = new BankovniUcet("Lubos", "000003/0100");
            lubosuvUcet.VypisInfo();

            lubosuvUcet.VlozPenize(4444);
            lubosuvUcet.VypisInfo();
        }
    }

    public class BankovniUcet
    {
        private string CisloUctu;
        private double Zustatek;
        private string JmenoMajitele;

        public BankovniUcet()
        {
            Zustatek = 500;
        }

        public BankovniUcet(string jmenoMajitele, string cisloUctu)
        {
            JmenoMajitele = jmenoMajitele;
            CisloUctu = cisloUctu;
            Zustatek = 1000;
        }

        public BankovniUcet NeKonstruktor()
        {
            return this;
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
