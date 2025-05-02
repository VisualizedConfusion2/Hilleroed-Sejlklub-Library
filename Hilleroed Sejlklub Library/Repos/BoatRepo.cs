using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hilleroed_Sejlklub_Library.Repos
{
    public class BoatRepo : IBoatRepo
    {
        public List<Boat> _boats;

        public BoatRepo()
        {
            _boats = new List<Boat>();
            Seed();
        }
        public void Add(Boat boat)
        {
            _boats.Add(boat);
        }
        
        public List<Boat> GetAll()
        {
            return _boats;
        }

        //DELETE LOGIC SIMPLIFIED NEEDS UPDATE
        public void Delete(int id)
        {
            Boat boat = _boats.FirstOrDefault(b => b.BoatId == id);
            _boats.Remove(boat);
        }

        //GETBYID LOGIC SIMPLIFIED NEEDS UPDATE
        public Boat GetById(int id)
        {
            Boat boat = _boats.FirstOrDefault(b => b.BoatId == id);
            return boat;
        }

        public void Seed()
        {
            _boats.Add(new Boat("object1", 1, "model", "type", "sailType", "motor", "measurement", "2004", false, "sejlbåd1.jpg"));
            _boats.Add(new Boat("object2", 1, "model", "type", "sailType", "motor", "measurement", "2002", false, "sejlbåd2.jpg"));
            _boats.Add(new Boat("object3", 1, "model", "type", "sailType", "motor", "measurement", "2001", false, "sejlbåd3.jpg"));
        }
    }
}
