using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Interfaces
{
    public interface IRepair
    {
        // Get all repair records
        List<Repair> GetAll();

        // Add a new repair record
        void Add(Repair repair);

        // Delete a repair record by ID
        void Delete(string RepairID);

        // Get a repair record by ID
        Repair GetById(string RepairID);

        // Update an existing repair record
        void Update(Repair repair);

        // Get the date of a repair by ID
        DateTime GetDate(string RepairID);

        // Get the description of a repair by ID
        string GetDescription(string RepairID);
    }
}
