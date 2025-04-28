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

        public Repair? GetRepairById(string id)
        {
            foreach (var repair in _repairs)
            {
                if (repair.RepairID == id)
                {
                    return repair;
                }
            }
            return null;
        }

        public void AddRepair(Repair repair)
        {
            foreach (var existingRepair in _repairs)
            {
                if (existingRepair.RepairID == repair.RepairID)
                {
                    throw new InvalidOperationException($"Repair with ID {repair.RepairID} already exists.");
                }
            }
            _repairs.Add(repair);
        }

        public bool UpdateRepair(string id, Repair updatedRepair)
        {
            var repair = GetRepairById(id);
            if (repair == null)
            {
                return false;
            }

            repair.Description = updatedRepair.Description;
            repair.Date = updatedRepair.Date;
            return true;
        }

        public bool DeleteRepair(string id)
        {
            var repair = GetRepairById(id);
            if (repair == null)
            {
                return false;
            }

            _repairs.Remove(repair);
            return true;
        }

        public Repair GetRepair(string repairID)
        {
            var repair = GetRepairById(repairID);
            if (repair == null)
            {
                throw new KeyNotFoundException($"Repair with ID {repairID} not found.");
            }
            return repair;
        }

        public List<Repair> GetRepairs()
        {
            var repairsCopy = new List<Repair>();
            foreach (var repair in _repairs)
            {
                repairsCopy.Add(repair);
            }
            return repairsCopy;
        }

        public void Delete(string repairID)
        {
            var repair = GetRepairById(repairID);
            if (repair == null)
            {
                throw new KeyNotFoundException($"Repair with ID {repairID} not found.");
            }
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
