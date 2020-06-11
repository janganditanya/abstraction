using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction");
            Console.WriteLine("");
            Hewan hewan;

            hewan = new Kucing();
            hewan.Bentuk();
            hewan.Suara();
           

            Console.WriteLine("");

            hewan = new Sapi();
            hewan.Bentuk();
            hewan.Suara();
           

            Console.WriteLine("");
            Console.WriteLine("Interface");
            Console.WriteLine("");
            IHewan ihewan;

            ihewan = new IKucing();
            ihewan.Bentuk();
            ihewan.Suara();
           

            Console.WriteLine("");

            ihewan = new ISapi();
            ihewan.Bentuk();
            ihewan.Suara();
            

            Console.ReadKey();
        }
    }
}
