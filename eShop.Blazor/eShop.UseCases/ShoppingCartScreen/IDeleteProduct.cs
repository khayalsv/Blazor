using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen
{
    public interface IDeleteProduct
    {
        Task<Order> Execute(int productId);
    }
}