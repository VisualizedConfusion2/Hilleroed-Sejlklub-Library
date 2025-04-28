namespace Hilleroed_Sejlklub_Library.Models
{
    public class Booking
    {
        private int _id;
        private string _location;
        private DateTime _timeOfBooking;

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
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
        public Booking(int _id, string _location, DateTime _timeOfBooking)
        {
            _id = Id;
            _location = Location;
            _timeOfBooking = TimeOfBooking;
        }
    }
}
