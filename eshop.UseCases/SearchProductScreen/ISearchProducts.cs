using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.UseCases.SearchProductScreen
{
    public interface ISearchProducts
    {
        public IEnumerable<Products> Execute(string filter);
    }
}
