namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public string Turunan(int[] persamaan)
        {
            string result = "";
            int derajat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i] * (derajat - i);
                int pangkat = derajat - i - 1;

                if (koef == 0) continue;

                if (result.Length > 0 && koef > 0)
                    result += " + ";
                else if (koef < 0)
                    result += " - ";

                result += $"{Math.Abs(koef)}";

                if (pangkat > 0)
                    result += $"x{(pangkat > 1 ? pangkat.ToString() : "")}";
            }

            return result;
        }

        public string Integral(int[] persamaan)
        {
            string result = "";
            int derajat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length; i++)
            {
                int pangkat = derajat - i + 1;
                double koef = (double)persamaan[i] / pangkat;

                if (persamaan[i] == 0) continue;

                if (result.Length > 0 && koef > 0)
                    result += " + ";
                else if (koef < 0)
                    result += " - ";

                result += $"{Math.Abs(koef)}x{(pangkat > 1 ? pangkat.ToString() : "")}";
            }

            result += " + C";
            return result;
        }
    }
}
