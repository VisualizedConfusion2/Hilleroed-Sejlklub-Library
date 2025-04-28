namespace Hilleroed_Sejlklub_Library.Models
{
    public class Booking
    {
        private int _bookingID;
        private string _location;
        private DateTime _timeOfBooking;

        public int BookingID
        {
            get { return _bookingID; }
            private set { _bookingID = value; }
        }

        public string Location
        {
            get { return _location; }
            private set { _location = value; }
        }

        public DateTime TimeOfBooking
        {
            get { return _timeOfBooking; }
            private set { _timeOfBooking = value; }
        }

        // Constructor
        public Booking(int _bookingID, string _location, DateTime _timeOfBooking)
        {
            _bookingID = BookingID;
            _location = Location;
            _timeOfBooking = TimeOfBooking;
        }
    }
}
