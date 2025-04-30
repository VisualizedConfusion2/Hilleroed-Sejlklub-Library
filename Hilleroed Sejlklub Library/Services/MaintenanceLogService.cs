using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using Hilleroed_Sejlklub_Library.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Services
{
    /// <summary>  
    /// The MaintenanceLogService class provides functionality to manage maintenance logs.  
    /// Implements the IMaintenanceLog interface.  
    /// </summary>  
    internal class MaintenanceLogService
    {
        // A private list to store maintenance logs  
        private IMaintenanceLogRepo _maintenanceLogRepo;

        /// <summary>  
        /// Constructor to initialize the MaintenanceLogService with an empty maintenance log list.  
        /// </summary>  
        public MaintenanceLogService(IMaintenanceLogRepo maintenenanceLogRepo)
        {
            _maintenanceLogRepo = maintenenanceLogRepo ?? throw new ArgumentNullException(nameof(maintenenanceLogRepo));
        }

        /// <summary>  
        /// Retrieves all maintenance logs in the system.  
        /// </summary>  
        /// <returns>A list of all maintenance logs.</returns>  
        public List<MaintenanceLog> GetAll()
        {
            return _maintenanceLogs.ToList();
        }

        /// <summary>  
        /// Adds a new maintenance log to the system.  
        /// </summary>  
        /// <param name="maintenanceLog">The maintenance log to add.</param>  
        public void Add(MaintenanceLog maintenanceLog)
        {
            _maintenanceLogs.Add(maintenanceLog);
        }

        /// <summary>  
        /// Deletes a maintenance log by its unique ID.  
        /// </summary>  
        /// <param name="maintenanceId">The ID of the maintenance log to delete.</param>  
        public void Delete(int maintenanceId)
        {
            MaintenanceLog log = null;
            foreach (MaintenanceLog maintenanceLog in _maintenanceLogs)
            {
                if (maintenanceLog.MaintenanceLogId == maintenanceId)
                {
                    log = maintenanceLog;
                    break;
                }
            }

            if (log != null)
            {
                _maintenanceLogs.Remove(log);
            }
        }
    }
}
