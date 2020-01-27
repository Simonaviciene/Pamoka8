using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmesVaisiai
{
    struct Palme
    {
        public int Amzius;
        public int VaisiuKiekis;

        public int amzius
        {
            get { return Amzius; }
            set { }
        }

        public int vaisiusKiekis
        {
            get { return VaisiuKiekis; }
            set { }
        }

        public void Prideti1MenAmziaus()
        {

            if ((amzius + 1) > 5 && (amzius + 1) < 12)
            {
                VaisiuKiekis = (amzius + 1 - 5) * 3;
            }
            else
            {
                VaisiuKiekis = 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
