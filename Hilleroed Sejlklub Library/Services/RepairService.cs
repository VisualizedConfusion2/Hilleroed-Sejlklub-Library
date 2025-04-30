using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Services
{
    // The RepairService class provides functionality to manage a collection of Repair objects.
    // It implements the IRepair interface and provides methods for CRUD operations on repairs.
    internal class RepairService : IRepairRepo
    {
        // A private list to store all repair records.
        private readonly List<Repair> _repairs;

        // Constructor initializes the _repairs list.
        public RepairService()
        {
            _repairs = new List<Repair>();
        }

        // Retrieves all repair records as a list.
        public List<Repair> GetAllRepairs()
        {
            return _repairs;
        }

        // Retrieves a specific repair by its ID. Returns null if not found.
        public Repair? GetRepairById(string id)
        {
            foreach (var repair in _repairs)
            {
                if (repair.RepairID == id)
                {
                    return repair; // Return the repair if the ID matches.
                }
            }
            return null; // Return null if no matching repair is found.
        }

        // Adds a new repair to the list. Throws an exception if a repair with the same ID already exists.
        public void AddRepair(Repair repair)
        {
            foreach (var existingRepair in _repairs)
            {
                if (existingRepair.RepairID == repair.RepairID)
                {
                    // Prevent duplicate entries by checking for an existing repair with the same ID.
                    throw new InvalidOperationException($"Repair with ID {repair.RepairID} already exists.");
                }
            }
            _repairs.Add(repair); // Add the new repair to the list.
        }

        // Updates an existing repair's details. Returns true if successful, false if the repair is not found.
        public bool UpdateRepair(string id, Repair updatedRepair)
        {
            var repair = GetRepairById(id); // Find the repair by ID.
            if (repair == null)
            {
                return false; // Return false if the repair is not found.
            }

            // Update the repair's properties with the new values.
            repair.Description = updatedRepair.Description;
            repair.Date = updatedRepair.Date;
            return true; // Indicate that the update was successful.
        }

        // Deletes a repair by its ID. Returns true if successful, false if the repair is not found.
        public bool DeleteRepair(string id)
        {
            var repair = GetRepairById(id); // Find the repair by ID.
            if (repair == null)
            {
                return false; // Return false if the repair is not found.
            }

            _repairs.Remove(repair); // Remove the repair from the list.
            return true; // Indicate that the deletion was successful.
        }
        // Returns a copy of all repairs in the list.
        public List<Repair> GetRepairs()
        {
            var repairsCopy = new List<Repair>();
            foreach (var repair in _repairs)
            {
                repairsCopy.Add(repair); // Add each repair to the copy list.
            }
            return repairsCopy; // Return the copied list.
        }

        // Deletes a repair by its ID. Throws an exception if the repair is not found.
        public void Delete(string repairID)
        {
            var repair = GetRepairById(repairID); // Find the repair by ID.
            if (repair == null)
            {
                // Throw an exception if the repair is not found.
                throw new KeyNotFoundException($"Repair with ID {repairID} not found.");
            }
            _repairs.Remove(repair); // Remove the repair from the list.
        }

        // Placeholder method for retrieving all repairs. Not yet implemented.
        public List<Repair> GetAll()
        {
            throw new NotImplementedException();
        }

        // Placeholder method for adding a repair. Not yet implemented.
        public void Add(Repair repair)
        {
            throw new NotImplementedException();
        }

        // Placeholder method for deleting a repair by integer ID. Not yet implemented.
        public void Delete(int RepairID)
        {
            throw new NotImplementedException();
        }

        public Repair GetById(string RepairID)
        {
            throw new NotImplementedException();
        }

        public void Update(Repair repair)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDate(string RepairID)
        {
            throw new NotImplementedException();
        }

        public string GetDescription(string RepairID)
        {
            throw new NotImplementedException();
        }
    }
}
