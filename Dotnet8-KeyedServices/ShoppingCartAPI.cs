namespace Dotnet8_KeyedServices
{
    public class ShoppingCartAPI : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded through API.";
        }
    }
}
