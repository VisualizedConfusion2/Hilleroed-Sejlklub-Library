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
    // Interface for Boat Repository
    public interface IBoatRepo
    {
        // Retrieves all boats from the repository
        public List<Boat> GetAll();

        // Adds a new boat to the repository
        public void Add(Boat boat);

        // Deletes a boat from the repository by its ID
        public void Delete(int id);

        // Seeds the repository with initial data
        public void Seed();
    }
}
