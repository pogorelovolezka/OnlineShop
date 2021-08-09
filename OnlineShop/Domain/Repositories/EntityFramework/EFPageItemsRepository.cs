using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Entities;
using OnlineShop.Domain.Repositories.Abstract;

namespace OnlineShop.Domain.Repositories.EntityFramework
{
    public class EFPageItemsRepository : IPageItemsRepository
    {

        private readonly AppDbContext context;
        public EFPageItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<PageItem> GetPageItems()
        {
            return context.PageItems1;
        }

        public PageItem GetPageItemById(Guid id)
        {
            return context.PageItems1.FirstOrDefault(x => x.Id == id);
        }

        public PageItem GetPageItemByCodeWord(string codeWord)
        {
            return context.PageItems1.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SavePageItem(PageItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeletePageItem(Guid id)
        {
            context.PageItems1.Remove(new PageItem() { Id = id });
            context.SaveChanges();
        }
    }
}
