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
        public virtual void Add(Boat boat)
        {
            _boats.Add(boat);
        }

        public void Delete(int id)
        {
            var boat = _boats.FirstOrDefault(b => b.BoatId == id);
            if (boat != null)
            {
                _boats.Remove(boat);
            }
        }

        public List<Boat> Get()
        {
            return _boats; // Ensure a value is always returned

        }

        public void GetById(int id)
        {
            var boat = _boats.FirstOrDefault(b => b.BoatId == id);
            if (boat != null)
            {
                // Logic to handle the found boat can be added here
            }
        }

        protected List<Boat> _boats = new List<Boat>();

        public BoatRepo()
        {
            _boats.Add(new Boat("object", 1, "model", "type", "sailType", "motor", "measurement", new DateTime(2000,1,1,1,1,1), false));
        }
    }
}
