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
        List<MaintenanceLog> GetAll();
        void Add(MaintenanceLog maintenanceLog);
        void Delete(int maintenanceLogId);
    }
}
