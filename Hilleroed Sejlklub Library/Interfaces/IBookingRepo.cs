using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Interfaces
{
    public interface IBookingRepo
    {
        // Get all booking records
        List<Booking> GetAll();

        // Add a new booking record
        void Add(Booking booking);

        // Delete a booking record by ID
        void Delete(int bookingID);
    }
}
