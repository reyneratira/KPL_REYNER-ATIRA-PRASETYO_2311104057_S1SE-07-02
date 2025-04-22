using modul6_2311104057;

public class Program
{
    public static void Main()
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Reyner");

            string[] filmList = {
                "Interstellar", "The Grand Budapest Hotel", "Fantastic Mr. Fox",
                "Inglorious Basterds", "Pulp Fiction", "Fallen Angels",
                "Chungking Express", "Dune", "Dune Part 2", "Spirited Away"
            };

            foreach (string film in filmList)
            {
                SayaTubeVideo video = new SayaTubeVideo($"Review Film {film} oleh {user.GetUsername()}");
                video.IncreasePlayCount(100000);
                user.addVideo(video);
            }

            user.printAllVideoCount();
            Console.WriteLine($"\nTotal Play Count: {user.GetTotalVideoCount()}");

            // Uji Exception Overflow
            SayaTubeVideo riskyVideo = new SayaTubeVideo("Review Film Yang Banyak Banget");
            for (int i = 0; i < 1000; i++)  // cukup cepat trigger overflow
            {
                riskyVideo.IncreasePlayCount(25000000);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi exception: {ex.Message}");
        }
    }
}
