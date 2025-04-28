using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Services
{
    internal class RepairService : IRepair
    {
        private readonly List<Repair> _repairs;

        public RepairService()
        {
            _repairs = new List<Repair>();
        }

        public IEnumerable<Repair> GetAllRepairs()
        {
            return _repairs;
        }

        public Repair? GetRepairById(string id) // Changed parameter type from int to string
        {
            return _repairs.FirstOrDefault(r => r.RepairID == id); // No changes needed here as both are strings now
        }

        public void AddRepair(Repair repair)
        {
            if (_repairs.Any(r => r.RepairID == repair.RepairID))
                throw new InvalidOperationException($"Repair with ID {repair.RepairID} already exists.");
            _repairs.Add(repair);
        }

        public bool UpdateRepair(string id, Repair updatedRepair) // Changed parameter type from int to string
        {
            var repair = GetRepairById(id);
            if (repair == null)
                return false;

            repair.Description = updatedRepair.Description;
            repair.Date = updatedRepair.Date;
            return true;
        }

        public bool DeleteRepair(string id) // Changed parameter type from int to string
        {
            var repair = GetRepairById(id);
            if (repair == null)
                return false;

            _repairs.Remove(repair);
            return true;
        }

        public Repair GetRepair(string repairID) // Changed parameter type from int to string
        {
            return GetRepairById(repairID) ?? throw new KeyNotFoundException($"Repair with ID {repairID} not found.");
        }

        public List<Repair> GetRepairs()
        {
            return _repairs.ToList();
        }

        public void Delete(string repairID) // Changed parameter type from int to string
        {
            var repair = GetRepairById(repairID);
            if (repair == null)
                throw new KeyNotFoundException($"Repair with ID {repairID} not found.");
            _repairs.Remove(repair);
        }

        public List<Repair> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Repair repair)
        {
            throw new NotImplementedException();
        }

        public void Delete(int RepairID)
        {
            throw new NotImplementedException();
        }
    }
}
