using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandObjects
{
    public class VideoGame
    {
        public string NameOfVideoGame { get; set; }
        public string TypeOfGame { get; set; }
        public string TypeOfGamingDevice { get; set; }

        public int GameReleaseYear { get; set; }

        public bool OnlineOrOffline { get; set; }
    }
}
