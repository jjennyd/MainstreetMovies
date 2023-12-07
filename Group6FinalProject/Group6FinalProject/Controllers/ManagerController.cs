using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Group6FinalProject.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            //// Verify if the user is in the manager role
            //if (!User.IsInRole("Manager"))
            //{
            //    return Unauthorized();
            //}

            return View();
        }

        // Additional actions will redirect to the specific functionality
    }

}

