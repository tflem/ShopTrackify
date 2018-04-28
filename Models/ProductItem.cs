using System;

namespace ShopTrackify.Models
{
    public class ProductItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
