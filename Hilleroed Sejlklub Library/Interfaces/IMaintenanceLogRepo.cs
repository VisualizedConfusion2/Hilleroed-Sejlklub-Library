using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hilleroed_Sejlklub_Library.Models;

namespace Hilleroed_Sejlklub_Library.Interfaces
{
    interface IMaintenanceLogRepo
    {
        List<MaintenanceLog> GetAll();
        void Add(MaintenanceLog maintenanceLog);
        void Delete(int maintenanceID);
    }
}
