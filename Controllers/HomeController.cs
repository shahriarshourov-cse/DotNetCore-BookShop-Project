﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Shop.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "I am from controller";
        }
    }
}
