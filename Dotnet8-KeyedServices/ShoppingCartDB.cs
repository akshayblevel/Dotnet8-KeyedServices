﻿namespace Dotnet8_KeyedServices
{
    public class ShoppingCartDB : IShoppingCart
    {
        public object GetCart()
        {
            return "Cart loaded from DB";
        }
    }
}
