using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hilleroed_Sejlklub_Library.Models;

namespace Hilleroed_Sejlklub_Library.Interfaces
{
    public interface IBoatRepo
    {
        public List<Boat> GetAll();
        public void Add(Boat boat);
        public void Delete(int id);
        public void Seed();
    }
}
