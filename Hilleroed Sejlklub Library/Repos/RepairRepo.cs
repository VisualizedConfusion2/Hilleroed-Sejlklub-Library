using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;

namespace Hilleroed_Sejlklub_Library.Repos
{
    public class RepairRepo : IRepairRepo
    {
        // List to store all repair records
        private readonly List<Repair> _repairs;

        // Constructor to initialize the repair list
        public RepairRepo()
        {
            _repairs = new List<Repair>();
        }

        // Retrieve all repair records
        public List<Repair> GetAll()
        {
            List<Repair> result = new List<Repair>();
            // Iterate through the list and add each repair to the result
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
            Repair toDelete = null;
            // Find the repair record with the matching ID
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repairID)
                {
                    toDelete = _repairs[i];
                    break;
                }
            }

            // Remove the repair record if found
            if (toDelete != null)
            {
                _repairs.Remove(toDelete);
            }
        }

        // Retrieve a repair record by its ID
        public Repair GetById(string repairID)
        {
            // Iterate through the list to find the matching repair
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repairID)
                {
                    return _repairs[i];
                }
            }
            return null; // Return null if no match is found
        }

        // Update an existing repair record
        public void Update(Repair repair)
        {
            if (repair == null)
            {
                return; // Exit if the repair object is null
            }

            // Find the repair record with the matching ID and update its properties
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repair.RepairID)
                {
                    _repairs[i].Description = repair.Description;
                    _repairs[i].Date = repair.Date;
                    return;
                }
            }
        }

        // Get the date of a repair by its ID
        public DateTime GetDate(string repairID)
        {
            // Iterate through the list to find the matching repair
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repairID)
                {
                    return _repairs[i].Date;
                }
            }
            return default(DateTime); // Return default value if no match is found
        }

        // Get the description of a repair by its ID
        public string GetDescription(string repairID)
        {
            // Iterate through the list to find the matching repair
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repairID)
                {
                    return _repairs[i].Description;
                }
            }
            return null; // Return null if no match is found
        }
        // Retrieve all repair records (alias for GetAll)
        public List<Repair> Get()
        {
            return GetAll();
        }
    }
}