using OnlineShop.Domain.Entities;
using System.Collections.Generic;

namespace OnlineShop.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<ProductItem> ProductItems { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
