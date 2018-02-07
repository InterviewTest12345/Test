using Interview.CSharp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.CSharp.Infrastructure
{
    public class OrganizationContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public OrganizationContext(DbContextOptions<OrganizationContext> options) 
            : base(options)
        {
        }
    }

    public static class SeedData
    {
        /// <summary>
        /// Just make some dummy data
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void Initialize(IServiceProvider serviceProvider)
        {

            var orgNames = new string[]
            {
                "Tom's Hardware",
                "Rick's Pet Bugs",
                "Totally Not the NSA",
                "Jane and Tom's Bistro",
            };

            var streetAddresses = new string[]
            {
                "123 Main Street",
                "22nd Maple Ave",
                "65215 Washington Drive",
                "PO BOX 123"
            };

            var cities = new string[]
            {
                "Anytown",
                "Somewheresville",
                "Old York",
                "Overthere"
            };

            var states = new string[]
            {
                "CA",
                "WI",
                "ND",
                "FL",
                "IL"
            };

            var postalCodes = new string[]
            {
                "87621",
                "90210",
                "43432",
                "81818"
            };

            var phoneNumbers = new string[]
            {
                "(123) 543 8765",
                "(324) 235 8234",
                "(999) 123 8743",
                "(124) 555 1298",
                "(912) 217 8137",
                "(543) 867 2361"
            };

            var empFirstNames = new string[]
            {
                "Bob",
                "Carl",
                "Jane",
                "Becca",
                "Jose",
                "Namit",
                "Bhanu"
            };

            var empLastName = new string[]
            {
                "Smith",
                "Thomas",
                "Jenkins",
                "Hernandez",
                "Ali",
                "Vashisht",
            };

            var empTitle = new string[]
            {
                "Developer",
                "Mechanic",
                "Pilot",
                "Customer Service Representative",
                "Service Center Worker",
                "Driver",
                "Project Manager",

            };

            using (var context = new OrganizationContext(serviceProvider
                                                .GetRequiredService<DbContextOptions<OrganizationContext>>()))
            {
                // Look for any organizations.
                if (context.Organizations.Any())
                {
                    return;
                }

                Random rdm = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < 20; i++)
                {
                    var orgId = Guid.NewGuid();
                    var orgName = orgNames[rdm.Next(0, orgNames.Length - 1)];
                    var streetAddress = streetAddresses[rdm.Next(0, streetAddresses.Length - 1)];
                    var city = cities[rdm.Next(0, cities.Length - 1)];
                    var state = states[rdm.Next(0, states.Length - 1)];
                    var postalCode = postalCodes[rdm.Next(0, postalCodes.Length - 1)];
                    var phone = phoneNumbers[rdm.Next(0, phoneNumbers.Length - 1)];

                    var employess = new List<Employee>();
                    for (int j = 0; j < 10; j++)
                    {
                        var fname = empFirstNames[rdm.Next(0, empFirstNames.Length - 1)];
                        var lname = empLastName[rdm.Next(0, empLastName.Length - 1)];
                        var title = empTitle[rdm.Next(0, empTitle.Length - 1)];

                        employess.Add(new Employee
                        {
                            EmployeeId = Guid.NewGuid(),
                            FirstName = fname,
                            LastName = lname,
                            EmailAddress = String.Format("{0}.{1}@{2}.com", fname, lname, orgName),
                            Title = title,
                            OrganizationId = orgId
                        });
                    }

                    context.Organizations.Add(new Organization
                    {
                        OrganizationId = orgId,
                        Name = orgName,
                        PhoneNumber = phone,
                        Address = new Address()
                        {
                            AddressId = Guid.NewGuid(),
                            StreetAddress = streetAddress,
                            City = city,
                            State = state,
                            PostalCode = postalCode
                        },
                        Employees = employess
                    });
                }

                context.SaveChanges();
            }
        }
    }
}