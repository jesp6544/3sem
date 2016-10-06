using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;

namespace JSON_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Savegame tmp = new Savegame();
            tmp.gameName = "test";
            tmp.location = "C:/test/test";

            Savegame[] savegames = new Savegame[10];
            savegames[0] = tmp;
            savegames[1] = new Savegame(){location = "whatever", gameName = "that game"};
            
                string test = JsonConvert.SerializeObject(savegames, Formatting.Indented);
            dynamic testing = JsonConvert.DeserializeObject(test);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"config.JSON",test);
            Console.ReadLine();
        }
    }

    class Savegame
    {
        public string location { get; set; }
        public string gameName { get; set; }
        //public string (save platform, steam, uplay, gog etc.)
    }
}
