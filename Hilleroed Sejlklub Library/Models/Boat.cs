namespace Hilleroed_Sejlklub_Library.Models
{
    public class Boat
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string SailType { get; set; }
        public string Motor { get; set; }
        public string Measurement { get; set; }
        public DateTime Year { get; set; }
        public bool Usable { get; set; }
        public Boat(string name, int id, string model, string type, string sailType, string motor, string measurement, DateTime year, bool usable)
        {
            Name = name;
            Id = id;
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
