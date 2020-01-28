using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavDarbas4_unitTest
{
     public struct Miskas
    {
        public List<int> medziai;

        public void PasodintiMedi()
        {

            int medis = 1;
            medziai.Add(medis);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Miskas miskas;
            miskas.medziai = new List<int>();

            for (int i = 0; i <= 16; i++);
            {
                miskas.PasodintiMedi();
            }
            Console.WriteLine("{}", miskas.medziai);
            Console.ReadLine();


        }
    }
}
