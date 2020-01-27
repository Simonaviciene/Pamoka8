using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavDarbas_UnitTest
{
    public struct Saskaita
    {
        public string Gavejas;
        public string Siuntejas;
        public double MoketiViso;
        public string SaskaitosNumeris;

        public Saskaita(string gavejas, string siuntejas, double moketiViso)
        {
            Gavejas = gavejas;
            Siuntejas = siuntejas;
            MoketiViso = moketiViso;
            SaskaitosNumeris = 
                "NR" + 
                DateTime.Now.Year + 
                "_" + DateTime.Now.Month + "_" + 
                DateTime.Now.Day + "_01";

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Saskaita saskaita = new Saskaita("Jonas", "Antanas", 12);
            Console.WriteLine("{0}, {1}, {2}, {3}", saskaita.Gavejas, saskaita.Siuntejas, saskaita.MoketiViso, saskaita.SaskaitosNumeris);
            Console.ReadLine();
        }
    }
}
