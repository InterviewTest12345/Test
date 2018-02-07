using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.CSharp.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Title { get; set; }

        public Guid OrganizationId { get; set; }
    }
}
