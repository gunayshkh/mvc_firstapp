﻿using Microsoft.AspNetCore.Mvc;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1.Collections
{
    public class AboutController: Controller
    {
        public string Index()
        {
            return "About US";
        }
    }
}
