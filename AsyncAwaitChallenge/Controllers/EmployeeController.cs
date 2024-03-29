﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncAwaitChallenge.Models;
using AsyncAwaitChallenge.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoAPI.Controllers
{
           
    [ApiController]
    public class EmployeeController : Controller
    {
        private IDataService _dataService;

        public EmployeeController(IDataService dataService)
        {
            _dataService = dataService;
        }
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            logger.LogInformation("Created");
        }

       
        [HttpGet]
        [Route("api/getallemployees")]
        public ActionResult<List<EmployeeData>> GetEmployees()
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


            return Ok(employees);
        }
    }
}

