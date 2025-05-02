namespace Hilleroed_Sejlklub_Library.Models
{
    public class MaintenanceLog
    {
        // Property to store the date of regular maintenance
        public DateTime RegularMaintenance { get; set; }

        // Unique identifier for the maintenance log
        public int MaintenanceLogId { get; set; }

        // Constructor to initialize the MaintenanceLog object with an ID and maintenance date
        public MaintenanceLog(int maintenanceLogId, DateTime regularMaintenance)
        {
            MaintenanceLogId = maintenanceLogId;
            RegularMaintenance = regularMaintenance;
        }

        // Overrides the ToString method to provide a formatted string representation of the maintenance log
        public override string ToString()
        {
            return $"Vedligeholdelsen blev udført: {RegularMaintenance:d}";
        }
    }
}
