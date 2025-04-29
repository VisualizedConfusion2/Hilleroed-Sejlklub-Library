namespace Hilleroed_Sejlklub_Library.Models
{
    public class Booking
    {
        public int BookingID { get; private set; }
        public string Location { get; private set; }
        public DateTime TimeOfBooking { get; private set; }

        public Booking(int bookingID, string location, DateTime timeOfBooking)
        {
            BookingID = bookingID;
            Location = location;
            TimeOfBooking = timeOfBooking;
        }

        public override string ToString()
        {
            return $"BookingID: {BookingID}, Location: {Location}, Time: {TimeOfBooking:g}";
        }
    }
}