using modul13_2311104057;

class Program
{
    static void Main(string[] args)
    {
        // Inisialisasi data1 dan data2 dari Singleton
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // Tambahkan nama anggota dan asisten
        data1.AddSebuahData("Anggota 1: Aldi");
        data1.AddSebuahData("Anggota 2: Budi");
        data1.AddSebuahData("Asisten: Kak Fikri");

        // Print data menggunakan data2
        Console.WriteLine("Data melalui data2:");
        data2.PrintSemuaData();

        // Hapus data asisten pada data2
        data2.HapusSebuahData(2); // index ke-2 (asisten)

        // Print ulang dari data1
        Console.WriteLine("\nData melalui data1 setelah penghapusan:");
        data1.PrintSemuaData();

        // Hitung jumlah data
        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}