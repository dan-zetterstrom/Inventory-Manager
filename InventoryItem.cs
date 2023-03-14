using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    public class InventoryItem
    {
        public InventoryItem(string description, string quantity, string category, string location) 
        {
            Description = description;
            Quantity = quantity;
            Category = category;
            Location = location;
        }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
    }
}
