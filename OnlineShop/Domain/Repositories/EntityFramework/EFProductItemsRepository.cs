using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Entities;
using OnlineShop.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Repositories.EntityFramework
{
    public class EFProductItemsRepository : IProductItemsRepository
    {
        private readonly AppDbContext context;

        //Cart
        public IQueryable<ProductItem> ProductsCart => context.ProductItems1;

        public EFProductItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ProductItem> GetProductItems()
        {
            return context.ProductItems1;
        }

        public ProductItem GetProductItemById(Guid id)
        {
            return context.ProductItems1.FirstOrDefault(x => x.Id == id);
        }

        public void SaveProductItem(ProductItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteProductItem(Guid id)
        {
            context.ProductItems1.Remove(new ProductItem() { Id = id });
            context.SaveChanges();
        }
    }
}
