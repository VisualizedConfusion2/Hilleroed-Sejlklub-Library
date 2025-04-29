using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using Hilleroed_Sejlklub_Library.Repos;
using System;
using System.Collections.Generic;

namespace Hilleroed_Sejlklub_Library.Services
{
    public class BoatService
    {
        private IBoatRepo _boatRepo;

        public BoatService(IBoatRepo boatRepo)
        {
            _boatRepo = boatRepo ?? throw new ArgumentNullException(nameof(boatRepo));
        }

        public List<Boat> Get()
        {
            List<Boat> boatsCopy = new List<Boat>();
            foreach (Boat boat in _boats)
            {
                boatsCopy.Add(boat);
            }
            return boatsCopy;
        }

        public void Add(Boat boat)
        {
            foreach (Boat existingBoat in _boats)
            {
                if (existingBoat.BoatId == boat.BoatId)
                {
                    throw new InvalidOperationException($"Boat with ID {boat.BoatId} already exists.");
                }
            }
            _boats.Add(boat);
        }

        public void Delete(int id)
        {
            Boat? boat = GetByIdInternal(id);
            if (boat == null)
            {
                throw new KeyNotFoundException($"Boat with ID {id} not found.");
            }
            _boats.Remove(boat);
        }

        public void GetById(int id)
        {
            Boat? boat = GetByIdInternal(id);
            if (boat == null)
            {
                throw new KeyNotFoundException($"Boat with ID {id} not found.");
            }
        }

        private Boat? GetByIdInternal(int id)
        {
            foreach (Boat boat in _boats)
            {
                if (boat.BoatId == id)
                {
                    return boat;
                }
            }
            return null;
        }
    }
}

