﻿
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
        public Player() { fileLocation = ""; }
        public static Player MakeNewPlayer(string FileLocation)
        {
            Player p = new Player
            {
                fileLocation = FileLocation
            };

            return p;
        }
        public string fileLocation;

        /*PLAYER MANAGEMENT*/
        public static Player LoadPlayer(string fileLocation)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            Player p;
            using (StreamReader sr = new StreamReader(fileLocation))
            {
                p = (Player)serializer.Deserialize(sr);
            }
            return p;
        }
        public void SaveAs(string filePath)
        {
            fileLocation = filePath;
            XmlSerializer serializer = new XmlSerializer(typeof(Player));

            using (StreamWriter sw = new StreamWriter(fileLocation))
            {
                serializer.Serialize(sw, this);
            }
        }
        public void SaveFile()
        {            
            XmlSerializer serializer = new XmlSerializer(typeof(Player));

            using (StreamWriter sw = new StreamWriter(fileLocation))
            {
                serializer.Serialize(sw, this);
            }
        }
    }
}
