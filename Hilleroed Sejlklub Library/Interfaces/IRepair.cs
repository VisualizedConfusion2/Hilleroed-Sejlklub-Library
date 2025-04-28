using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Interfaces
{
    interface IRepair
    {
        // Get all repair records
        List<Repair> GetAll();

        // Add a new repair record
        void Add(Repair repair);

        // Delete a repair record by ID
        void Delete(int RepairID);
    }
}
