﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.Services
{
    class TestServiceOne : ITestService
    {
        public string Test()
        {
            return "Hello from Gleb!";
        }
    }
}
