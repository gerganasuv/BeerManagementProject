using System;
using System.Collections.Generic;
using System.Text;
using static BeerManagement.Data.DatabaseConstants;
using System.ComponentModel.DataAnnotations;

namespace BeerManagement.Data.Models
{
    public class Beers
    {

        public int Id { get; set; }

        public int ManufactureId { get; set; }

        public Manufactures Manufacture { get; set; }

        [Required]
        [MinLength(BeerDescriptionMin)]
        [MaxLength(BeerDescriptionMax)]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [MinLength(BeerNationalityMin)]
        [MaxLength(BeerNationalityMin)]
        public string Nationality { get; set; }

        [Range(0, 30)]
        public double AlcoholPercentage { get; set; }

        public List<Orders> Order { get; set; } = new List<Orders>();








    }
}
