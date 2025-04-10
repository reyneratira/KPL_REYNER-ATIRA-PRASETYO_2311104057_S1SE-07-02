using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random rand = new Random(); // menggunakan class bawaan System untuk random
        this.id = rand.Next(10000, 99999); // ID 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
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
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Reyner Atira Prasetyo");
        video.IncreasePlayCount(100); // penambahan playCount
        video.PrintVideoDetails();
    }
}
