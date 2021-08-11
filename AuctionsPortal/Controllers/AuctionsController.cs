using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartlomiejJagielloLab5ZadDom.Models;
using Microsoft.EntityFrameworkCore;

namespace BartlomiejJagielloLab5ZadDom.Controllers
{
    public class AuctionsController : Controller
    {
        // Database reference
        private readonly DataBaseContext _context;

        // Get reference to database
        public AuctionsController(DataBaseContext context)
        {
            this._context = context;
        }

        // Get index page
        public IActionResult Index()
        {
            // Include auction seller
            var auctions = _context.Auctions.Include(s => s.Seller).Include(i => i.Item).ToList();
           
            return View(_context.Auctions.ToList());
        }

        // Get create auction page
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Get created auction
        [HttpPost]
        public IActionResult Create(Auction auction)
        {
            // Two steps: adding and saving new auction do database
            _context.Auctions.Add(auction);
            _context.SaveChanges();

            // Return to main page
            return RedirectToAction(nameof(Index));
        }

        // Go to remove selected auction page
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Include all bids and their users and also item
            var auction = _context.Auctions.Include(a => a.Bids).ThenInclude(bid => bid.User).Include(i => i.Item).FirstOrDefault(a => a.Id.Equals(id));
            // If user manually changed id and was not found
            if (auction == null)
            {
                return NotFound();
            }

            return View(auction);
        }

        // Remove after confirmation
        [HttpPost]
        public IActionResult Delete(Auction auction)
        {
            // Remove range to delete all bids
            _context.Bids.RemoveRange(_context.Bids.Where(m => m.Auction.Equals(auction)));
            // Delete auction
            _context.Auctions.Remove(auction);
            // Save changes
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // Go update page
        [HttpGet]
        public IActionResult Update(int id)
        {
            // get auction with given id
            var auction = _context.Auctions.FirstOrDefault(a => a.Id.Equals(id));

            // If user manually changed id and was not found
            if (auction == null)
            {
                return NotFound();
            }

            return View(auction);
        }

        // Update auction data
        [HttpPost]
        public IActionResult Update(Auction auction)
        {
            if (ModelState.IsValid)
            {
                // Change entity
                _context.Auctions.Update(auction);
                // Save to database
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(auction.Id);
        }
    }
}
