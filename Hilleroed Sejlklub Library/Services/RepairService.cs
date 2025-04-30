using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;

namespace Hilleroed_Sejlklub_Library.Services
{
    /// <summary>
    /// Service class for handling repair logic using an injected repository.
    /// </summary>
    public class RepairService
    {
        private readonly IRepairRepo _repairRepo;

        /// <summary>
        /// Constructor that takes a repository implementing IRepairRepo.
        /// </summary>
        public RepairService(IRepairRepo repairRepo)
        {
            _repairRepo = repairRepo ?? throw new ArgumentNullException(nameof(repairRepo));
        }

        /// <summary>
        /// Returns all repairs.
        /// </summary>
        public List<Repair> Get()
        {
            return _repairRepo.Get();
        }

        /// <summary>
        /// Adds a repair.
        /// </summary>
        public void Add(Repair repair)
        {
            _repairRepo.Add(repair);
        }

        /// <summary>
        /// Deletes a repair by ID.
        /// </summary>
        public void Delete(string repairID)
        {
            _repairRepo.Delete(repairID);
        }

        /// <summary>
        /// Gets a repair by ID.
        /// </summary>
        public Repair GetById(string repairID)
        {
            return _repairRepo.GetById(repairID);
        }

        /// <summary>
        /// Updates an existing repair.
        /// </summary>
        public void Update(Repair repair)
        {
            _repairRepo.Update(repair);
        }

        /// <summary>
        /// Gets the date of a repair.
        /// </summary>
        public DateTime GetDate(string repairID)
        {
            return _repairRepo.GetDate(repairID);
        }

        /// <summary>
        /// Gets the description of a repair.
        /// </summary>
        public string GetDescription(string repairID)
        {
            return _repairRepo.GetDescription(repairID);
        }
    }
}