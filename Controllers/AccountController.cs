using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class AccountController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            string a = "asdfasdf";
            return View();
        }
        
    }
}