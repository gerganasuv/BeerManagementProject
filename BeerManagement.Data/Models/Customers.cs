using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static BeerManagement.Data.DatabaseConstants;

namespace BeerManagement.Data.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required]
        [MinLength(NameCustomerMin)]
        [MaxLength(NameCustomerMax)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(NameCustomerMin)]
        [MaxLength(NameCustomerMax)]
        public string LastName { get; set; }

        [Required]
        public string DeliveryAddress { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public List<Orders> Order { get; set; } = new List<Orders>();
    }
}
