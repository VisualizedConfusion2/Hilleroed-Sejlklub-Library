namespace Hilleroed_Sejlklub_Library.Models
{
    public class Booking
    {
        // Unique identifier for the booking
        public int BookingID { get; private set; }

        // Location associated with the booking
        public string Location { get; private set; }

        // Date and time when the booking was made
        public DateTime TimeOfBooking { get; private set; }

        // Constructor to initialize a Booking object with its properties
        public Booking(int bookingID, string location, DateTime timeOfBooking)
        {
            BookingID = bookingID;
            Location = location;
            TimeOfBooking = timeOfBooking;
        }

        // Overrides the default ToString method to provide a formatted string representation of the booking
        public override string ToString()
        {
            return $"BookingID: {BookingID}, Location: {Location}, Time: {TimeOfBooking:g}";
        }
    }
}