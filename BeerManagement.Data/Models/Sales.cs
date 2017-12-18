using System;
using System.Text;

namespace BeerManagement.Data.Models
{
    public class Sales
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Orders Order { get; set; }

        public DateTime ShipmentTime { get; set; }

        public decimal BeerPrice { get; set; }

        public Beers Beer { get; set; }


    }
}
