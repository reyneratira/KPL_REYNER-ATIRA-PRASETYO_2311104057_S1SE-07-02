using System;

class Program
{
    static void Main()
    {
        SapaPengguna();
        TampilkanDeretAngkaDenganSimbol(50);
        CekBilanganPrima();
    }

    // Soal A
    static void SapaPengguna()
    {
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");
    }

    // Soal B
    static void TampilkanDeretAngkaDenganSimbol(int ukuran)
    {
        int[] angka = new int[ukuran];

        for (int i = 0; i < ukuran; i++)
        {
            angka[i] = i;
        }

        for (int i = 0; i < ukuran; i++)
        {
            Console.Write($"{angka[i]}");

            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine(" #$#$");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine(" ##");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine(" $$");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }

    // Soal C
    static void CekBilanganPrima()
    {
        int nilai = BacaAngkaValid(1, 1000);

        if (ApakahPrima(nilai))
        {
            Console.WriteLine($"{nilai} adalah bilangan prima.");
        }
        else
        {
            Console.WriteLine($"{nilai} bukan bilangan prima.");
        }
    }

    static int BacaAngkaValid(int min, int max)
    {
        while (true)
        {
            Console.Write($"Masukkan angka antara {min} sampai {max}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int nilai) && nilai >= min && nilai <= max)
            {
                return nilai;
            }

            Console.WriteLine($"Angka harus antara {min} - {max}.");
        }
    }

    static bool ApakahPrima(int angka)
    {
        if (angka == 1) return false;
        for (int i = 2; i <= Math.Sqrt(angka); i++)
        {
            if (angka % i == 0)
                return false;
        }
        return true;
    }
}
