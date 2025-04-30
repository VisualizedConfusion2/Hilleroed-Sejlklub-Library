using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;

namespace Hilleroed_Sejlklub_Library.Services
{
    internal class RepairService : IRepairRepo
    {
        // List to store all repair records
        private readonly List<Repair> _repairs;

        // Constructor to initialize the repair list
        public RepairService()
        {
            _repairs = new List<Repair>();
        }

        // Retrieve all repair records
        public List<Repair> GetAll()
        {
            List<Repair> result = new List<Repair>();
            for (int i = 0; i < _repairs.Count; i++)
            {
                result.Add(_repairs[i]);
            }
            return result;
        }

        // Add a new repair record to the list
        public void Add(Repair repair)
        {
            if (repair != null)
            {
                _repairs.Add(repair);
            }
        }

        // Delete a repair record by its ID
        public void Delete(string repairID)
        {
            Repair repairToDelete = null;

            // Find the repair record with the matching ID
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repairID)
                {
                    repairToDelete = _repairs[i];
                    break;
                }
            }

            // Remove the repair record if found
            if (repairToDelete != null)
            {
                _repairs.Remove(repairToDelete);
            }
        }

        // Retrieve a repair record by its ID
        public Repair GetById(string repairID)
        {
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repairID)
                {
                    return _repairs[i];
                }
            }
            return null;
        }

        // Update an existing repair record
        public void Update(Repair updatedRepair)
        {
            if (updatedRepair == null)
            {
                return;
            }

            // Find the repair record with the matching ID and update its properties
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == updatedRepair.RepairID)
                {
                    _repairs[i].Description = updatedRepair.Description;
                    _repairs[i].Date = updatedRepair.Date;
                    return;
                }
            }
        }

        // Get the date of a repair by its ID
        public DateTime GetDate(string repairID)
        {
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repairID)
                {
                    return _repairs[i].Date;
                }
            }
            return default(DateTime);
        }

        // Get the description of a repair by its ID
        public string GetDescription(string repairID)
        {
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repairID)
                {
                    return _repairs[i].Description;
                }
            }
            return null;
        }
    }
}