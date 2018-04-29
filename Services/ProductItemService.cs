using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopTrackify.Data;
using ShopTrackify.Models;
using Microsoft.EntityFrameworkCore;

namespace ShopTrackify.Services
{
    public class ProductItemService : IProductItemService
    {
        private readonly ApplicationDbContext _context;

        public ProductItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductItem>> GetRemainingProductsAsync()
        {
            var products = await _context.Products
                .Where(x => x.Id != null)
                .ToArrayAsync();

            return products;
        }
    }
}
