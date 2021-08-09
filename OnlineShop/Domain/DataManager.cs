using OnlineShop.Domain.Repositories;
using OnlineShop.Domain.Repositories.Abstract;

namespace OnlineShop.Domain
{
    public class DataManager
    {
        public IPageItemsRepository PageItems { get; set; }
        public IProductItemsRepository ProductItems { get; set; }

        public DataManager(IPageItemsRepository pageItemsRepository, IProductItemsRepository productItemsRepository)
        {
            PageItems = pageItemsRepository;
            ProductItems = productItemsRepository;
        }
    }
}
