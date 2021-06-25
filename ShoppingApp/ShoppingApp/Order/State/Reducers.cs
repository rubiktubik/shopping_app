using ReduxSimple;
using ShoppingApp.State;
using System.Collections.Generic;

using static ReduxSimple.Reducers;
using static ShoppingApp.Order.State.Selectors;
using static ShoppingApp.Order.State.Entities;
using ShoppingApp.Order.Domain;

namespace ShoppingApp.Order.State
{
    public static class Reducers
    {
        public static IEnumerable<On<RootState>> GetReducers()
        {
            return CreateSubReducers(SelectOrderState)
                        .On<InitializeOrderAction>(state => {
                            var mockShoppingCartItems = new List<ShoppingCartItem>()
                            {
                                new ShoppingCartItem(new ShoppingCartItemId(1),
                                                     new Product(new ProductId(1),109.95m,"Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops"),
                                                     0),
                                new ShoppingCartItem(new ShoppingCartItemId(2),
                                                     new Product(new ProductId(2),22.3m,"Mens Casual Premium Slim Fit T-Shirts"),
                                                     0)
                            };
                            return state with
                            {
                                ShoppingCartItems = ShoppingCartItemAdapter.AddAll(mockShoppingCartItems, state.ShoppingCartItems),
                            };
                        })
             .ToList();
        }
    }
}
