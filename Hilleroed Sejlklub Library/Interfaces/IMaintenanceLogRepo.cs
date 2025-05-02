using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hilleroed_Sejlklub_Library.Models;
using Hilleroed_Sejlklub_Library.Models;
using System.Collections.Generic;

namespace Hilleroed_Sejlklub_Library.Interfaces
{
    public interface IMaintenanceLogRepo
    {
        // Retrieves a list of all maintenance logs
        List<MaintenanceLog> Get();

        // Adds a new maintenance log to the repository
        void Add(MaintenanceLog maintenanceLog);

        // Deletes a maintenance log from the repository by its ID
        void Delete(int maintenanceLogId);
    }
}
