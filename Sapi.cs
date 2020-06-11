using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Sapi : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Suarakuuu moooo mooooo.....");
        }
        public override void Bentuk()
        {
            Console.WriteLine("Aku adalah Sapi. Badanku besar dan berwarna putih atau coklat, manusia senang meminum susuku");
        }
    }
}
