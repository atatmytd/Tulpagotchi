
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Xml.Serialization;
using System.IO;

namespace Tulpagotchi
{
    public class Player
    {
        public static Player MakeNewPlayer(string FileLocation)
        {
            Player p = new Player
            {
                fileLocation = FileLocation
            };

            return p;
        }
        public string fileLocation;
    }
}
