namespace Hilleroed_Sejlklub_Library.Models
{
    public class MaintenanceLog
    {
        public DateTime RegularMaintenance { get; set; }
        public int MaintenanceLogId { get; set; }

        public MaintenanceLog(DateTime regularMaintenance)
        {
            regularMaintenance = RegularMaintenance;
        }
        
        public override string ToString()
        {
            return $"Vedligholdelsen blev udført: {RegularMaintenance:d}";
        }
    }
}
