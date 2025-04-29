using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Hilleroed_Sejlklub_Library.Repos
{
    public class JsonRepo : BoatRepo
    {
        public JsonRepo()
        {
            LoadFile();
        }

        private void LoadFile()
        {
            string path = "json1.json";
            string json = File.ReadAllText(path);

            _boats = JsonSerializer.Deserialize<List<Boat>>(json);
        }

        public override void Add(Boat boat)
        {
            base.Add(boat);
            SaveFile();
        }

        private void SaveFile()
        {
            string path = "json1.json";
            File.WriteAllText(path, JsonSerializer.Serialize(_boats));
        }

    }
}
