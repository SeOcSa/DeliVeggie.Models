using System;

namespace DeliVeggie.Models.Responses
{
    public class ProductDetailsResponse : ProductsResponse
    {
        public DateTime? EntryDate { get; set; }
        public double? PriceWithReduction { get; set; }
    }
}