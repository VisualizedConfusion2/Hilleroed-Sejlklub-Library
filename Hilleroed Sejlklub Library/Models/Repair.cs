namespace Hilleroed_Sejlklub_Library.Models
{
    public class Repair
    {
        public DateTime Date { get; set;}
        public string Description { get; set;}

        public string RepairID { get; set;}

        public Repair(DateTime date, string description, string repairid)
        {
            Date = date;
            Description = description;
            RepairID = repairid;
        }

        public override string ToString()
        {
            return $"{Date:d}: {Description}";
        }

    }
}
