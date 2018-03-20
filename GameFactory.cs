using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab2
{
    class GameFactory
    {
        List<Game> gamelist = new List<Game>();
        public string FilePath = "games.xml";
        public GameFactory()
        {

        }

        public void CreateGameList()
        {
            gamelist.Add(new Game("Lions", "Bears", 0, 1));
            gamelist.Add(new Game("Dolphins", "Lions", 6, 12));
            gamelist.Add(new Game("Bears", "Dolphins", 0, 0));
            gamelist.Add(new Game("Tigers", "Dolphins", 12, 16));
            gamelist.Add(new Game("Tigers", "Bears", 7, 18));
            gamelist.Add(new Game("Lions", "Tigers", 18, 26));

        }

        public Boolean SerializeGameList()
        {
            StreamWriter sw = new StreamWriter(FilePath);
            XmlSerializer ser = new XmlSerializer(gamelist.GetType());
            ser.Serialize(sw, gamelist);
            sw.Close();
            return true;
        }
    }
}
