using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.CSharp.Models
{
    public class EmployeesByTitle
    {
        public string Title { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
