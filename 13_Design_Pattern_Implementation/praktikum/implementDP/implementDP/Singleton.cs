using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_dp
{
    public sealed class Rektor
    {
        public static Rektor? _instance;
        private Rektor()
        {
            Console.WriteLine("Rektor baru dipilih!");
        }

        public static Rektor GetRektor()
        {
            if (_instance == null)
            {
                _instance = new Rektor();
            }
            return _instance;
        }

        public void tandaTangan()
        {
            Console.WriteLine("Rektor menandatangani surat!");
        }
    }
    class Singleton
    {
    }
}
