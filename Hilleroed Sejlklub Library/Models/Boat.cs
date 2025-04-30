namespace Hilleroed_Sejlklub_Library.Models
{
    public class Boat
    {
        public string Name { get; private set; }
        public int BoatId { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
        public string SailType { get; private set; }
        public string Motor { get; private set; }
        public string Measurement { get; private set; }
        public string Year { get; private set; }
        public bool Usable { get; private set; }

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
