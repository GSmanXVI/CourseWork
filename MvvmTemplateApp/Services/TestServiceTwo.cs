﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.Services
{
    class TestServiceTwo : ITestService
    {
        public string Test()
        {
            return "Hello from test service two!";
        }
    }
}
