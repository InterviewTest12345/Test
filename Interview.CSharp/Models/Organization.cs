using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.CSharp.Models
{
    public class Organization
    {
        public Organization()
        {
            Employees = new List<Employee>();
        }

        [Key]
        public Guid OrganizationId {  get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Address Address { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
