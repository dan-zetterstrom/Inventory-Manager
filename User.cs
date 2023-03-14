using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager
{
    public class User
    {
        public User(string firstName, string lastName, string office, string title, string startDate, string termDate = "")
        {
            FirstName = firstName;
            LastName = lastName;
            Office = office;
            Title = title;
            StartDate = startDate;
            TermDate = termDate;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Office { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
        public string TermDate { get; set; }

    }
}
