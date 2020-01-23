using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStruct;

namespace OOPBibl1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book knyga;
            knyga.Name = "varda";
            knyga.ID = "0123";

            string locId = knyga.LocalID;
            knyga.LocalID = "abs";

            Console.WriteLine(knyga.Name);
            Console.ReadLine();
        }
    }
}
