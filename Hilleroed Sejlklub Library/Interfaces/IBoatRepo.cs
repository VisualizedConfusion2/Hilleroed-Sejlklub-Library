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
        List<Boat> Get();
        void Add(Boat boat);
        void Delete(int id);
        Boat GetById(int id);
        List<Boat> GetAll();
    }
}
