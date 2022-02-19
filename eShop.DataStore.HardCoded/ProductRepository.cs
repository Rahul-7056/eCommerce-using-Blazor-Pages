using eshop.UseCases.PluginsInterface.DataStore;
using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.DataStore.HardCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Products> products;
        public ProductRepository()
        {
            new Products
            {
                Id = 1,
                Brand = "zara",
                Name = "Shirt",
                Price = "500",
                Description = "catch-all term for a broad variety" +
                " of upper-body garments and undergarments",
                ImageLink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQP_XNPvgavgHQgJaCWMH3KgcmK5d7rZjoihg&usqp=CAU"
            };
            new Products
            {
                Id = 1,
                Brand = "zara",
                Name = "Shirt",
                Price = "500",
                Description = "catch-all term for a broad variety" +
                " of upper-body garments and undergarments",
                ImageLink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQP_XNPvgavgHQgJaCWMH3KgcmK5d7rZjoihg&usqp=CAU"
            };

        }

        public IEnumerable<Products> GetProducts(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return products;
            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }

        public Products GetProducts(int id)
        {
            return products.FirstOrDefault(x=>x.Id == id);
        }
    }
}
