using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Cart.LocalStorage
{
    public class ShoppingCart : IShoppingCart
    {

        public Task<Order> AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Order> DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task EmptyAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> PlaceOrderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateQuentityAsync(int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
