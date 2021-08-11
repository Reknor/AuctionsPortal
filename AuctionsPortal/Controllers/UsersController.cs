using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartlomiejJagielloLab5ZadDom.Models;
using Microsoft.EntityFrameworkCore;

namespace BartlomiejJagielloLab5ZadDom.Controllers
{
    public class UsersController : Controller
    {
        // Database reference
        private readonly DataBaseContext _context;

        // Get reference to database
        public UsersController(DataBaseContext context)
        {
            this._context = context;
        }

        // Show all users
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }
    }
}
