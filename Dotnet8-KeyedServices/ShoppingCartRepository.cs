using System.ComponentModel.DataAnnotations;

namespace Dotnet8_KeyedServices
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly IServiceProvider serviceProvider;

        public ShoppingCartRepository(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public object GetCart(CartSource cartSource)
        {
            var shoppingCart = this.serviceProvider.GetRequiredKeyedService<IShoppingCart>(cartSource);
            return shoppingCart.GetCart();
        }
    }
}
