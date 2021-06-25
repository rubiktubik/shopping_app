using ReduxSimple;
using ReduxSimple.Entity;
using ShoppingApp.Order.Domain;
using ShoppingApp.State;
using System.Collections.Generic;
using static ReduxSimple.Selectors;
using static ShoppingApp.Order.State.Entities;

namespace ShoppingApp.Order.State
{
    public static class Selectors
    {
        public static ISelectorWithoutProps<RootState, OrderState> SelectOrderState = CreateSelector(
            (RootState state) => state.Order
        );

        public static ISelectorWithoutProps<RootState, decimal> SelectSum = CreateSelector(
            SelectOrderState,
            (state) => state.Sum
        );

        public static ISelectorWithoutProps<RootState, bool> SelectIsLoading = CreateSelector(
            SelectOrderState,
            (state) => state.IsLoading
        );

        // Selectors for ShoppingCartItem-List
        private static readonly ISelectorWithoutProps<RootState, ShoppingCartItemEntityState> SelectShoppingCartItemsEntityState = CreateSelector(
            SelectOrderState,
            state => state.ShoppingCartItems
        );
        private static readonly EntitySelectors<RootState, ShoppingCartItemId, ShoppingCartItem> ShoppingCartItemsSelector = ShoppingCartItemAdapter.GetSelectors(SelectShoppingCartItemsEntityState);

        public static ISelectorWithoutProps<RootState, List<ShoppingCartItem>> SelectShoppingCartItems = ShoppingCartItemsSelector.SelectEntities;
    }
}
