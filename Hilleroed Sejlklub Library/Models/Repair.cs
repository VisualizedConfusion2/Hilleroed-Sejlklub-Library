namespace Hilleroed_Sejlklub_Library.Models
{
    public class Repair
    {
        // Property to store the date of the repair
        public DateTime Date { get; set; }

        // Property to store a description of the repair
        public string Description { get; set; }

        // Property to store a unique identifier for the repair
        public string RepairID { get; set; }

        // Constructor to initialize a Repair object with date, description, and repair ID
        public Repair(DateTime date, string description, string repairid)
        {
            Date = date;
            Description = description;
            RepairID = repairid;
        }

        // Override of the ToString method to provide a formatted string representation of the Repair object
        public override string ToString()
        {
            return $"{Date:d}: {Description}: {RepairID}";
        }
    }
}
