using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    public class Device
    {
        public Device(string category, string hostName, string make, string model, string assignedTo, string snType, string serialNumber, string status, string startDate)
        {
            Category = category;
            HostName = hostName;
            Make = make;
            Model = model;
            AssignedTo = assignedTo;
            SNType = snType;
            SerialNumber = serialNumber;
            Status = status;
            StartDate = startDate;
        }

        public string Category { get; set; }
        public string HostName { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string AssignedTo { get; set; }
        public string SNType { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }
        public string StartDate { get; set; }
        
    }
}
