using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_2311104057
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // Design By Contract
            if (title.Length > 200)
                throw new ArgumentException("Judul tidak boleh lebih dari 200 karakter");
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Judul tidak boleh kosong");

            this.id = new Random().Next(10000,99999);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            // Design By Contract
            if (playCount > 25000000)
                throw new ArgumentException("Play count tidak boleh lebih dari 25.000.000");
            if (playCount < 0)
                throw new ArgumentException("Play count cannot be negative");
            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Play count overflow");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
        public int GetPlayCount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
