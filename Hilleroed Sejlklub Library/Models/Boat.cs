namespace Hilleroed_Sejlklub_Library.Models
{
    public class Boat
    {
        // The name of the boat
        public string Name { get; set; }

        // Unique identifier for the boat
        public int BoatId { get; set; }

        // The model of the boat
        public string Model { get; set; }

        // The type/category of the boat
        public string Type { get; set; }

        // The type of sail used by the boat
        public string SailType { get; set; }

        // Information about the motor of the boat
        public string Motor { get; set; }

        // Measurement details of the boat
        public string Measurement { get; set; }

        // The year the boat was manufactured
        public string Year { get; set; }

        // Indicates whether the boat is currently usable
        public bool Usable { get; set; }
        public string Image {  get; set; }

        // Default constructor
        public Boat() { }

        public Boat(string name, int id, string model, string type, string sailType, string motor, string measurement, string year, bool usable, string image)
        {
            Name = name;
            BoatId = id;
            Model = model;
            Type = type;
            SailType = sailType;
            Motor = motor;
            Measurement = measurement;
            Year = year;
            Usable = usable;
            Image = image;
        }
    }
}
