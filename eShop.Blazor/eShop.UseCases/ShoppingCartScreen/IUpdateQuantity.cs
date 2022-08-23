using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen
{
    public interface IUpdateQuantity
    {
        Task<Order> Execute(int productId, int quanity);
    }
}