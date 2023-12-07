// Author: Group 6 
// Date: 
// Assignment: Final Project 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group_6_Final_Project.Models;
using Group_6_Final_Project.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace Group_6_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public IActionResult Index()
        {
            return View();
        }
    }
}