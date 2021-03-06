using ShoppingApp.Order.Domain;
using System;
using System.Collections.Generic;

namespace ShoppingApp.Order.State
{
    public record InitializeOrderAction();
    public record InitializeOrderActionSuccess(List<ShoppingCartItem> ShoppingCartItems);
    public record InitializeOrderActionFailure(Exception Exception);
}
