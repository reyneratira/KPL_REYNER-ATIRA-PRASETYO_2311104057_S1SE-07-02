using System;
using System.Globalization;
using tpmodul8_NIM;

class Program
{
    public static void Main()
    {
        CovidConfig config = CovidConfig.LoadConfig();

        // Memanggil UbahSatuan (soal G)  
        config.UbahSatuan();

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        string? inputSuhu = Console.ReadLine();
        if (inputSuhu == null)
        {
            Console.WriteLine("Input suhu tidak boleh kosong.");
            return;
        }

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        string? inputHari = Console.ReadLine();
        if (inputHari == null)
        {
            Console.WriteLine("Input hari tidak boleh kosong.");
            return;
        }

        if (!double.TryParse(inputSuhu, NumberStyles.Any, CultureInfo.InvariantCulture, out double suhu) ||
            !int.TryParse(inputHari, out int hari))
        {
            Console.WriteLine("Input tidak valid.");
            return;
        }

        bool suhuNormal = false;

        if (config.satuan_suhu == "celcius")
        {
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        }
        else if (config.satuan_suhu == "fahrenheit")
        {
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;
        }

        if (suhuNormal && hari < config.batas_hari_deman)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }
    }
}
