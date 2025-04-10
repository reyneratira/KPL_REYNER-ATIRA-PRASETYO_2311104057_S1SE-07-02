using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        // Validasi judul agar tidak null atau terlalu panjang
        if (string.IsNullOrEmpty(title) || title.Length > 100)
            throw new ArgumentException("Judul video tidak valid");
        Random rand = new Random(); // menggunakan class bawaan System untuk random
        this.id = rand.Next(10000, 99999); // ID 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 10000000)
            throw new ArgumentOutOfRangeException("count", "Penambahan play count harus di antara 0 dan 10.000.000");

        try
        {
            // Mencegah overflow dengan checked
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Terjadi overflow saat menambah play count: " + ex.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID       : " + id);
        Console.WriteLine("Video Title    : " + title);
        Console.WriteLine("Play Count     : " + playCount);
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – John Doe");
            video.PrintVideoDetails();

            Console.WriteLine("\nMenambahkan play count dalam loop untuk menguji overflow...");

            // Loop besar untuk menguji overflow
            for (int i = 0; i < 1000000; i++)
            {
                video.IncreasePlayCount(10000000); // Tambah besar agar cepat overflow
            }

            Console.WriteLine("\nSetelah penambahan play count:");
            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception terjadi di Main: " + ex.Message);
        }
    }
}
