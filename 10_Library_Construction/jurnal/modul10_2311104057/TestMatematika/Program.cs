using System;
using MatematikaLibraries;

class Program
{
    static void Main()
    {
        Matematika mtk = new Matematika();

        Console.WriteLine("FPB(60, 45) = " + mtk.FPB(60, 45));
        Console.WriteLine("KPK(12, 8) = " + mtk.KPK(12, 8));

        int[] turunanInput = { 1, 4, -12, 9 };
        Console.WriteLine("Turunan({1, 4, -12, 9}) = " + mtk.Turunan(turunanInput));

        int[] integralInput = { 4, 6, -12, 9 };
        Console.WriteLine("Integral({4, 6, -12, 9}) = " + mtk.Integral(integralInput));

        Console.ReadKey();
    }
}
