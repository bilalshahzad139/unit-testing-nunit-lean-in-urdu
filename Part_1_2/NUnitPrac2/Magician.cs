using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPrac2
{
    public class Magician
    {
        public int DoMagic(String param)
        {
            if (param.Equals("ABC"))
                return 10;
            else if (param.Equals("XYZ"))
                return 20;
            else
                return 30;
        }
    }
}
