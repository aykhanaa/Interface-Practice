﻿using Practice_Interface_services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interface_services.Helpers.Responses
{
    public class EmployeeResponse
    {
        public Employee Employee { get; set; }
        public string ErrorMessage { get; set; }
    }
}
