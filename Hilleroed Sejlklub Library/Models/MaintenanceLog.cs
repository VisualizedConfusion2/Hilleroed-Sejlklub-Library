namespace Hilleroed_Sejlklub_Library.Models
{
    public class MaintenanceLog
    {
        public DateTime RegularMaintenance { get; set; }
        
        public override string ToString()
        {
            return $"Vedligholdelsen er udført: {RegularMaintenance:d}";
        }
    }
}
