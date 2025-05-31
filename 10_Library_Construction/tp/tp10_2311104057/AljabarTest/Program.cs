using System;
using AljabarLibraries;

class Program
{
    static void Main()
    {
        Console.WriteLine("Test AkarPersamaanKuadrat:");
        double[] persamaanKuadrat = { 1, -3, -10 };
        double[] akar = Aljabar.AkarPersamaanKuadrat(persamaanKuadrat);
        Console.WriteLine(string.Join(", ", akar));  // Output: 5, -2

        Console.WriteLine("\nTest HasilKuadrat:");
        double[] persamaanLinear = { 2, -3 };
        double[] hasilKuadrat = Aljabar.HasilKuadrat(persamaanLinear);
        Console.WriteLine(string.Join(", ", hasilKuadrat)); // Output: 4, -12, 9
    }
}
