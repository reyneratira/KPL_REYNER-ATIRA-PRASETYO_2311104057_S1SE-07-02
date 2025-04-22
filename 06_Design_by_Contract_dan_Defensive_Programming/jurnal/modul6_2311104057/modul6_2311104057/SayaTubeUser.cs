using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_2311104057
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string username;

        public SayaTubeUser(string username)
        {
            this.id = new Random().Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void addVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public int GetTotalVideoCount()
        {
            int totalPlayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }

            return totalPlayCount;
        }

        public void printAllVideoCount()
        {
            Console.WriteLine($"User: {username}");
            int i = 1;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                Console.WriteLine($"Video {i} judul: {video.GetTitle()}");
                i++;
            }
        }

        public string GetUsername()
        {
            return username;
        }
    }
}
