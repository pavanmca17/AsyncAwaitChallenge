using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncAwaitChallenge.Models;

namespace AsyncAwaitChallenge.Service
{
    public class DataService : IDataService
    {
        public async Task<List<EmployeeData>> GetEmployees()
        {
            var employees = new List<EmployeeData>()
            {
                new EmployeeData()
                {
                    ID = 1,
                    FirstName = "First Name",
                    LastName = "Last Name",
                    DateOfBirth = DateTime.Now.AddYears(-30)
                },
                new EmployeeData()
                {
                    ID = 2,
                    FirstName = "First Name",
                    LastName = "Last Name",
                    DateOfBirth = DateTime.Now.AddYears(-37)
                },
                new EmployeeData()
                {
                    ID = 3,
                    FirstName = "First Name",
                    LastName = "Last Name",
                    DateOfBirth = DateTime.Now.AddYears(-3)
                },
                 new EmployeeData()
                {
                    ID = 3,
                    FirstName = "First Name",
                    LastName = "Last Name",
                    DateOfBirth = DateTime.Now.AddYears(-1)
                }
            };

            return await Task.FromResult<List<EmployeeData>>(employees);

        }
    }
}
