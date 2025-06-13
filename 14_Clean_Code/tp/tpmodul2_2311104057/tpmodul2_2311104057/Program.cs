using System;

class Program
{
    static void Main()
    {
        // Modularity : Memecah program menjadi beberapa fungsi
        CekHurufVokalAtauKonsonan();
        TampilkanBilanganGenap(5);
    }

    // Soal A: Mengecek apakah huruf adalah vokal atau konsonan
    static void CekHurufVokalAtauKonsonan()
    {
        Console.Write("Masukkan satu huruf: ");
        char huruf = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (IsVokal(huruf))
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal.");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan.");
        }
    }

    static bool IsVokal(char huruf)
    {
        return "AIUEO".Contains(huruf);
    }

    // Soal B: Menampilkan deret bilangan genap
    static void TampilkanBilanganGenap(int jumlah)
    {
        int[] bilanganGenap = new int[jumlah];

        for (int i = 0; i < jumlah; i++)
        {
            bilanganGenap[i] = (i + 1) * 2;
        }

        for (int i = 0; i < jumlah; i++)
        {
            Console.WriteLine($"Angka genap ke-{i + 1}: {bilanganGenap[i]}");
        }
    }
}