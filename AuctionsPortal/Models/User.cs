using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BartlomiejJagielloLab5ZadDom.Models
{
    // User - seller or buyer, relations define role
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        // Plain text
        [Required]
        [MaxLength(64)]
        public string Password { get; set; }

        // User can have many auctions
        public ICollection<Auction> Auctions { get; set; }

        // User can buy in many auctions
        public ICollection<Bid> Bids { get; set; }
    }
}
