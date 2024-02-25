namespace Dotnet8_KeyedServices
{
    public class ShoppingCartCache : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded from cache.";
        }
    }
}
