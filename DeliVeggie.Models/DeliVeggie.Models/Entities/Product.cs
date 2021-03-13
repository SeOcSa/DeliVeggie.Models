using System;
using System.Collections.Generic;

namespace DeliVeggie.Models.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public DateTime? EntryDate { get; set; }
        public double? Price { get; set; }
        public IEnumerable<Price> PriceWithReduction { get; set; }
    }
}