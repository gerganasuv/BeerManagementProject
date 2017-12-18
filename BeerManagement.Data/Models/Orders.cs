using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BeerManagement.Data.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customers Customer { get; set; }

        [Required]
        public DateTime OrderedTime { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int BeerId { get; set; }

        public Beers Beer { get; set; }

        public List<Sales> Sale = new List<Sales>();
    }
}
