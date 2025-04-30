using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;

namespace Hilleroed_Sejlklub_Library.Repos
{
    public class RepairRepo : IRepairRepo
    {
        private readonly List<Repair> _repairs;

        public RepairRepo()
        {
            _repairs = new List<Repair>();
        }

        public List<Repair> GetAll()
        {
            List<Repair> result = new List<Repair>();
            for (int i = 0; i < _repairs.Count; i++)
            {
                result.Add(_repairs[i]);
            }
            return result;
        }

        public void Add(Repair repair)
        {
            if (repair != null)
            {
                _repairs.Add(repair);
            }
        }

        public void Delete(string repairID)
        {
            Repair toDelete = null;
            for (int i = 0; i < _repairs.Count; i++)
            {
                if (_repairs[i].RepairID == repairID)
                {
                    toDelete = _repairs[i];
                    break;
                }
            }

            if (toDelete != null)
            {
                _repairs.Remove(toDelete);
            }
        }

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

        public void Update(Repair repair)
        {
            if (repair == null)
            {
                return;
            }

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
        public List<Repair> Get()
        {
            return GetAll();
        }
    }
}