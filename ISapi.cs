using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class ISapi: IHewan
    {
        public void Suara()
        {
            Console.WriteLine("Suarakuuu moooo mooooo.....");
        }
        public void Bentuk()
        {
            Console.WriteLine("Aku adalah Sapi. Badanku besar dan berwarna putih atau coklat, manusia senang meminum susuku");
        }
    }
}
