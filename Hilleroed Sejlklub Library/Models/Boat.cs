namespace Hilleroed_Sejlklub_Library.Models
{
    public class Boat
    {
        public string Name { get; set; }
        public int BoatId { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string SailType { get; set; }
        public string Motor { get; set; }
        public string Measurement { get; set; }
        public string Year { get; set; }
        public bool Usable { get; set; }

        //default constructor
        public Boat()
        {
        }
        public Boat(string name, int id, string model, string type, string sailType, string motor, string measurement, string year, bool usable)
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
        }
    }
}
