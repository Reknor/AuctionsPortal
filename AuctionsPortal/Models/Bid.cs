using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BartlomiejJagielloLab5ZadDom.Models
{
    // Represent buy offer
    public class Bid
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int AuctionId { get; set; }

        [ForeignKey("AuctionId")]
        public Auction Auction { get; set; }
    }
}
