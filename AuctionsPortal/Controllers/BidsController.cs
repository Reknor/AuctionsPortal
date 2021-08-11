using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartlomiejJagielloLab5ZadDom.Models;
using Microsoft.EntityFrameworkCore;

namespace BartlomiejJagielloLab5ZadDom.Controllers
{
    public class BidsController : Controller
    {
        // Database reference
        private readonly DataBaseContext _context;

        // Get reference to database
        public BidsController(DataBaseContext context)
        {
            this._context = context;
        }

        // Show bids for selected auction
        public IActionResult Index(int auctionId)
        {
            // Get all bids
            var bids = _context.Bids.Where(b => b.AuctionId == auctionId).Include(b => b.User).Include(a => a.Auction);
            // Get current auction id for adding bids
            TempData["auctionId"] = auctionId;
            TempData["auctionName"] = _context.Auctions.Find(auctionId).Name;
            return View(bids);
        }

        // Get create bid page
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Get created bid
        [HttpPost]
        public IActionResult Create(Bid bid)
        {
            // Add auction id for bid
            bid.AuctionId = (int)TempData["auctionId"];
            bid.Auction = _context.Auctions.Where(a => a.Id == bid.AuctionId).FirstOrDefault();

            // Two steps: adding and saving new bid do database
            _context.Bids.Add(bid);
            _context.SaveChanges();

            // Return to main page
            return RedirectToAction(nameof(Index), new { auctionId = bid.AuctionId });
        }
    }
}
