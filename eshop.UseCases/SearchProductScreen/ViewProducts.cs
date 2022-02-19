using eshop.UseCases.PluginsInterface.DataStore;
using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.UseCases.SearchProductScreen
{
    public class ViewProducts:IViewProducts
    {
        private readonly IProductRepository productRepository;
        public ViewProducts(IProductRepository productRepository) 
        {
            this.productRepository = productRepository;
        }
        public Products Execute(int id)
        {
            return productRepository.GetProducts(id);
        }
    }
}
