namespace Dotnet8_KeyedServices
{
    public interface IShoppingCartRepository
    {
        object GetCart(CartSource cartSource);
    }
}
