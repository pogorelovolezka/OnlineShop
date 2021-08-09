using Microsoft.AspNetCore.Mvc;
using OnlineShop.Domain;
using System;
using System.Linq;
using OnlineShop.Models.ViewModels;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataManager dataManager;

        public int PageSize = 4;

        public ProductController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id, int productPage = 1)
        {
            if (id != default)
            {
                return View("Show", dataManager.ProductItems.GetProductItemById(id));
            }
            
            ViewBag.TextField = dataManager.PageItems.GetPageItemByCodeWord("PageProduct");
            //return View(dataManager.ProductItems.GetProductItems());
            //Cart
            return View(new ProductsListViewModel { ProductItems = dataManager.ProductItems.GetProductItems()
                .OrderBy(p => p.Id)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = dataManager.ProductItems.GetProductItems().Count()
                } });
        }
        //Cart
    
    }
}
