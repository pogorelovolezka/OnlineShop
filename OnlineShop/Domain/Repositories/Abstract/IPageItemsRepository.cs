using OnlineShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Repositories.Abstract
{
    public interface IPageItemsRepository
    {
        IQueryable<PageItem> GetPageItems();
        PageItem GetPageItemById(Guid id);
        PageItem GetPageItemByCodeWord(string codeWord);
        void SavePageItem(PageItem entity);
        void DeletePageItem(Guid id);
    }
}
