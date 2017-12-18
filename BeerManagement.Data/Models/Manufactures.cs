using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static BeerManagement.Data.DatabaseConstants;

namespace BeerManagement.Data.Models
{
    public class Manufactures
    {
        public int Id { get; set; }

        [Required]
        [MinLength(CompanyNameMin)]
        [MaxLength(CompanyNameMax)]
        public string CompanyName { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string BulstatNum { get; set; }

        [Required]
        public string OwnerName { get; set; }

        [Required]
        public string ContactName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public List<Beers> Beer { get; set; } = new List<Beers>();

    }
}
