using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BartlomiejJagielloLab5ZadDom.Models
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {

        }

        // Tables in database
        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Item> Items { get; set; }

        // Disable cascade delete using fluent api
        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Required to create successful migration, don't delete user when deleting bid
            modelBuilder.Entity<Bid>()
                .HasOne<User>(s => s.User)
                .WithMany(b => b.Bids)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Required to create successful migration, don't delete auction when deleting bid
            modelBuilder.Entity<Bid>()
                .HasOne<Auction>(s => s.Auction)
                .WithMany(b => b.Bids)
                .HasForeignKey(a => a.AuctionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Don't delete user when deleting auction
            modelBuilder.Entity<Auction>()
                .HasOne<User>(u => u.Seller)
                .WithMany(a => a.Auctions)
                .HasForeignKey(a => a.SellerId)
                .OnDelete(DeleteBehavior.Restrict);

            // User login must be unique
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Login)
                .IsUnique(true);
        }
    }
}
