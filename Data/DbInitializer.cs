using ShopTrackify.Models;
using System;
using System.Linq;

namespace ShopTrackify.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();        

        // Look for any products.
            if (context.Products.Any())
            {
                return;
            }

            var products = new ProductItem[]
            {
                new ProductItem{Name="Milk", Quantity=2},
                new ProductItem{Name="Eggs", Quantity=1},
                new ProductItem{Name="Water", Quantity=1},
                new ProductItem{Name="Chips", Quantity=3},
                new ProductItem{Name="Bread", Quantity=3},
                new ProductItem{Name="Ice Cream", Quantity=1},
                new ProductItem{Name="Soda Pop", Quantity=4},
                new ProductItem{Name="Sour Cream", Quantity=2},
            };
            foreach (ProductItem i in products)
            {
                context.Products.Add(i);
            }
            context.SaveChanges();   
        }
    }
}
