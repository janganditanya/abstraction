using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Kucing : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Suarakuuu meoong meongg .....");
        }
        public override void Bentuk()
        {
            Console.WriteLine("Aku adalah kucing. Badanku kecil dan memiliki banyak bulu yang halus, manusia senang bermain denganku");
        }
    }
}
