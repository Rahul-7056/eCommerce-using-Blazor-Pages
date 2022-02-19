using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.UseCases.SearchProductScreen
{
    public interface IViewProducts
    {
        Products Execute(int id);
    }
}
