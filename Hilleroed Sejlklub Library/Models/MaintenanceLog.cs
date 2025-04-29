namespace Hilleroed_Sejlklub_Library.Models
{
    public class MaintenanceLog
    {
        public DateTime RegularMaintenance { get; set; }
        public int MaintenanceLogId { get; set; }

        public MaintenanceLog(int maintenanceLogId, DateTime regularMaintenance)
        {
            MaintenanceLogId = maintenanceLogId;
            RegularMaintenance = regularMaintenance;
        }

        public override string ToString()
        {
            return $"Vedligeholdelsen blev udført: {RegularMaintenance:d}";
        }
    }
}
