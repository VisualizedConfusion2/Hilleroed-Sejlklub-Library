namespace Hilleroed_Sejlklub_Library.Models
{
    public class Repair
    {
        public DateTime Date { get; set;}
        public string Description { get; set;}

        public Repair(DateTime date, string description)
        {
            Date = date;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Date:d}: {Description}";
        }

    }
}
