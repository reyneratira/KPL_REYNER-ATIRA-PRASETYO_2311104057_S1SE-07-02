using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        // Akar-akar dari persamaan kuadrat
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                // Tidak memiliki akar real
                return new double[0];
            }

            double akar1 = (-b + Math.Sqrt(D)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(D)) / (2 * a);

            return new double[] { akar1, akar2 };
        }

        // Hasil kuadrat dari persamaan linear
        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double a2 = a * a;
            double ab2 = 2 * a * b;
            double b2 = b * b;

            return new double[] { a2, ab2, b2 };
        }
    }
}
