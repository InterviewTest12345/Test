using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.CSharp.Models
{
    public class OrganizationListVM
    {
        public Guid OrganizationId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int EmployeeCount { get; set; }
    }
}
