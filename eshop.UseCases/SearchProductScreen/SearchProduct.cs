using System;
using System.Collections.Generic;
using System.Text;
using eshop.UseCases.PluginsInterface.DataStore;
using eShop.CoreBusiness.Models;

namespace eshop.UseCases.SearchProductScreen
{
    public class SearchProduct : ISearchProducts
    {
        private readonly IProductRepository productRepository;
        public SearchProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Products> Execute(string filter) 
        {
            return productRepository.GetProducts(filter);
        }
    }
}
