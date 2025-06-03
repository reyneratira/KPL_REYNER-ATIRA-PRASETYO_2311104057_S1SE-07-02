using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul12_2311104057
{
    public class Utilities
    {
        public static int CariNilaiPangkat(int a, int b)
        {
            if (b == 0)
                return 1;
            if (b < 0)
                return -1;

            try
            {
                checked
                {
                    int hasil = 1;
                    for (int i = 1; i <= b; i++)
                    {
                        hasil *= a;
                    }

                    if (b > 10 || a > 100)
                        return -2;
                    return hasil;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }
    }
}
