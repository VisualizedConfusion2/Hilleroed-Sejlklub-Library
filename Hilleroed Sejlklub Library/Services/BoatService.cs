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

        private IBoatRepo _boatInterface;

        public BoatService(IBoatRepo boatInterface)
        {
            _boatInterface = boatInterface;
        }

        public List<Boat> GetAll()
        {
            return _boatInterface.GetAll();
        }

        public virtual void Add(Boat boat)
        {
            _boatInterface.Add(boat);
        }

        public void Delete(int boatId)
        {
            _boatInterface.Delete(boatId);
        }

    }
}

