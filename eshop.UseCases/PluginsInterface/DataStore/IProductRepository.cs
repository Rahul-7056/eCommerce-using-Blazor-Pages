using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.UseCases.PluginsInterface.DataStore
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetProducts(string filter = null);
        Products GetProducts(int id);
    }
}
 