using ShoppingApp.Order.Domain;
using ShoppingApp.Order.State;
using ShoppingApp.ViewModels;
using System;
using System.Collections.ObjectModel;
using static ShoppingApp.App;
using static ShoppingApp.Order.State.Selectors;

namespace ShoppingApp.Order.Presentation
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            Title = "Order";
            var shoppingCartDisposable = Store.Select(SelectShoppingCartItems)
                .Subscribe(x => CartItems = new ObservableCollection<ShoppingCartItem>(x));
            Disposables.Add(shoppingCartDisposable);

            Store.Dispatch(new InitializeOrderAction());
        }

        public ObservableCollection<ShoppingCartItem> CartItems { get; set; }
    }
}
