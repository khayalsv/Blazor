using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.ViewProductScreen
{
    public class AddProductToCart : IAddProductToCart
    {
        private readonly IProductRepository productRepository;
        private readonly IShoppingCart shoppingCart;

        public AddProductToCart(IShoppingCart shoppingCart, IProductRepository productRepository)
        {
            this.shoppingCart = shoppingCart;
            this.productRepository = productRepository;
        }

        public async void Execute(int productId)
        {
            var product = productRepository.GetProduct(productId);
            await shoppingCart.AddProductAsync(product);
        }
    }
}
