using ReduxSimple.Entity;
using ShoppingApp.Order.Domain;

namespace ShoppingApp.Order.State
{
    public class ShoppingCartItemEntityState : EntityState<ShoppingCartItemId,ShoppingCartItem> { }

    public static class Entities
    {
        public static EntityAdapter<ShoppingCartItemId, ShoppingCartItem> ShoppingCartItemAdapter { get; set; } 
            = EntityAdapter<ShoppingCartItemId, ShoppingCartItem>.Create(item => item.Id);
    }
}
