using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopTrackify.Models;

namespace ShopTrackify.Services
{
    public interface IProductItemService
    {
        Task<IEnumerable<ProductItem>> GetRemainingProductsAsync();
    }
}
