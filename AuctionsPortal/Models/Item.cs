using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BartlomiejJagielloLab5ZadDom.Models
{
    // Represents item on auction
    public class Item
    {
        [Key]
        public int Id { get; set;}

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        // Auction which this items belongs to
        public Auction Auction { get; set; }
    }
}
