using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using Hilleroed_Sejlklub_Library.Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Hilleroed_Sejlklub_Library.Services
{
    /// <summary>
    /// Boat service class that provides functionality to manage boats.
    /// </summary>
    public class BoatService
    {

        private IBoatRepo _boatRepo;

        public BoatService(IBoatRepo boatRepo)
        {
            _boatRepo = boatRepo ?? throw new ArgumentNullException(nameof(boatRepo));
        }
        
        public List<Boat> GetAll()
        {
            return _boatRepo.GetAll();
        }

        public List<Boat> Get()
        {
            return _boatRepo.Get();
        }

        public virtual void Add(Boat boat)
        {
            _boatRepo.Add(boat);
        }

        public void Delete(int boatId)
        {
            _boatRepo.Delete(boatId);
        }

        public void GetById(int id)
        {
          // missing logic here
        }

    }
}

