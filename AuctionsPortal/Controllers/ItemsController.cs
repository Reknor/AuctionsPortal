using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartlomiejJagielloLab5ZadDom.Models;
using Microsoft.EntityFrameworkCore;

namespace BartlomiejJagielloLab5ZadDom.Controllers
{
    public class ItemsController : Controller
    {
        // Database reference
        private readonly DataBaseContext _context;

        // Get database reference
        public ItemsController(DataBaseContext context)
        {
            this._context = context;
        }

        // Show items list
        public IActionResult Index()
        {
            return View(_context.Items.ToList());
        }

        // Show create item page
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Get created item
        [HttpPost]
        public IActionResult Create(Item item)
        {
            // Two steps: adding and saving new item do database
            _context.Items.Add(item);
            _context.SaveChanges();

            // Return to main page
            return RedirectToAction(nameof(Index));
        }

    }
}
