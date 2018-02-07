using Interview.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Interview.CSharp.Infrastructure
{
    public interface ISimpleRepository
    {
        // Organization
        List<OrganizationListVM> GetAll();
        Organization Get(Guid id);
        List<Organization> FindOrganizations(string searchStr);

        // Employees
        List<Employee> GetEmployeesForgOrganization(Guid id);
        List<Employee> GetEmployeesByTitle(string title);

        // But Why?
        List<EmployeesByTitle> GroupEmployeesByTitle();
    }
    
    public class SimpleRepository : ISimpleRepository
    {
        public SimpleRepository()
        {
        }

        public List<OrganizationListVM> GetAll()
        {
            throw new NotImplementedException();
        }

        public Organization Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Organization> FindOrganizations(string searchStr)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeesForgOrganization(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeesByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<EmployeesByTitle> GroupEmployeesByTitle()
        {
            throw new NotImplementedException();
        }
    }
}
