using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b10302068_b10302066_B10302060
{
    class Class2
    {
        public bool IsPrime(int n)
        {

            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;

            throw new NotImplementedException();
        }
    }
}
