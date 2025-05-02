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
        // Constructor that initializes the repository by loading data from the JSON file
        public JsonRepo()
        {
            LoadFile();
        }

        // Private method to load boat data from a JSON file
        private void LoadFile()
        {
            string path = "json1.json"; // Path to the JSON file
            string json = File.ReadAllText(path); // Read the content of the JSON file

            // Deserialize the JSON content into a list of Boat objects
            _boats = JsonSerializer.Deserialize<List<Boat>>(json);
        }

        // Adds a new boat to the repository and saves the updated data to the JSON file
        public void Add(Boat boat)
        {
            base.Add(boat); // Call the base class method to add the boat
            SaveFile(); // Save the updated list of boats to the JSON file
        }

        // Private method to save the current list of boats to the JSON file
        private void SaveFile()
        {
            string path = "json1.json"; // Path to the JSON file
            // Serialize the list of boats into JSON format and write it to the file
            File.WriteAllText(path, JsonSerializer.Serialize(_boats));
        }
    }
}
