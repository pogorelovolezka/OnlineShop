using OnlineShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Repositories.Abstract
{
    public interface IProductItemsRepository
    {
        //IQueryable<ProductItem> Products { get; }
        //CArt
        //Cart
        IQueryable<ProductItem> ProductsCart { get; }
        IQueryable<ProductItem> GetProductItems();
        ProductItem GetProductItemById(Guid id);
        void SaveProductItem(ProductItem entity);
        void DeleteProductItem(Guid id);
    }
}
