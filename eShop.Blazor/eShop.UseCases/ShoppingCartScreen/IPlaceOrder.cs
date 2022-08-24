using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen
{
    public interface IPlaceOrder
    {
        Task<string> Execute(Order order);
    }
}