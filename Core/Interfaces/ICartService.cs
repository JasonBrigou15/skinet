using Core.Entities;

namespace Core.Interfaces;

public interface ICartService
{
    Task<ShoppingCart?> GetCartAsync(string key);
    Task<ShoppingCart?> SetCardAsync(ShoppingCart cart);
    Task<bool> DeleteCartAsync(string key);
}
