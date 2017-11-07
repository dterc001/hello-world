using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;



namespace Game
{
    public class GameFactory
    {
        List<Games> gameList;
        StreamWriter sw;
        XmlSerializer serial;
        const String FILEPATH = @"..\..\Games.xml";
        

      public void CreateGameList()
        {
            gameList = new List<Games>();
            Games G = new Games("Panthers", 20, "Dolphins", 15);

            gameList.Add(G);

            G = new Games("Alligators", 9, "Bears", 7);

            gameList.Add(G);
            G = new Games("Kangaroo", 15, "Iguana", 12);

            gameList.Add(G);
            G = new Games("Frogs", 99, "Turtles", 99);

            gameList.Add(G);
            G = new Games("Wolves", 29, "Cheetah", 29);

            gameList.Add(G);
            G = new Games("Cubs", 2, "Bobcats", 6);

            gameList.Add(G);

            serial = new XmlSerializer(gameList.GetType());
            sw = new StreamWriter(FILEPATH);
            serial.Serialize(sw, gameList);

            
            sw.Close();

        }

       /* public List<Games> DeserializeGameList()
        {

            gameList = new List<Games>();
            StreamReader sr = new StreamReader(FILEPATH);
            serial = new XmlSerializer(gameList.GetType());
            gameList = (List<Games>)serial.Deserialize(sr);

            
            sr.Close();
            return gameList;
            

           
        

        }*/

    }
}
