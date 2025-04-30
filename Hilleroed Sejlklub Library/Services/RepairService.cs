using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;

namespace Hilleroed_Sejlklub_Library.Services
{
    // Provides services for managing repairs.
    public class RepairService
    {
        private readonly IRepairRepo _repairRepo;

        public RepairService(IRepairRepo repairRepo)
        {
            _repairRepo = repairRepo ?? throw new ArgumentNullException(nameof(repairRepo));
        }

        // Gets a list of all repairs.
        public List<Repair> GetAll()
        {
            return _repairRepo.GetAll();
        }

        //Gets a repair by its ID.
        public Repair? GetById(string repairID)
        {
            return _repairRepo.GetById(repairID);
        }

        // Adds a new repair.
        public void Add(Repair repair)
        {
            if (repair == null)
                throw new ArgumentNullException(nameof(repair));

            _repairRepo.Add(repair);
        }
        // Deletes a repair by its string ID.
        public void Delete(string repairID)
        {
            _repairRepo.Delete(repairID);
        }
        //Updates an existing repair.
        public void Update(Repair repair)
        {
            if (repair == null)
                throw new ArgumentNullException(nameof(repair));

            _repairRepo.Update(repair);
        }
        // Gets the date of a repair by its ID.
        public DateTime GetDate(string repairID)
        {
            return _repairRepo.GetDate(repairID);
        }
        // Gets the description of a repair by its ID.
        public string GetDescription(string repairID)
        {
            return _repairRepo.GetDescription(repairID);
        }
    }
}