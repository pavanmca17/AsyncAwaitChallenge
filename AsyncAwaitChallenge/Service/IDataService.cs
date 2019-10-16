using AsyncAwaitChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncAwaitChallenge.Service
{
    public interface IDataService
    {
        Task<List<EmployeeData>> GetEmployees();       
    }
}
