using modul6_2311104057;

public class Program
{
    public static void Main()
    {
        SayaTubeUser sayaTubeUser = new SayaTubeUser("Reyner");

        string[] filmList = new string[] {
        "Interstellar", "The Grand Budapest Hotel", "Fantastic Mr. Fox", "Inglorious Basterds", "Pulp Fiction",
        "Fallen Angels", "Chungking Express", "Dune", "Dune Part 2","Spirited Away"};

        foreach (string film in filmList)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {film} oleh {sayaTubeUser.GetUsername()}");
            video.IncreasePlayCount(1000);
            sayaTubeUser.addVideo(video);
        }

        sayaTubeUser.printAllVideoCount();
        Console.WriteLine($"\nTotalPlayCount: {sayaTubeUser.GetTotalVideoCount()}");

    }
}