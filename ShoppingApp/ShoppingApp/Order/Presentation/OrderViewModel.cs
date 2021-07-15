using ShoppingApp.Order.Domain;
using ShoppingApp.Order.State;
using ShoppingApp.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using static ShoppingApp.App;
using static ShoppingApp.Order.State.Selectors;
using static ShoppingApp.Order.State.Effects;

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

            Store.ObserveAction<FillNamesActionSuccess>()
                .Subscribe(action => {
                    var tmp = action.Names;
                });

            Store.RegisterEffects(GetNames);
        }

        public ObservableCollection<ShoppingCartItem> CartItems { get; set; }

        public void GetNamesCommand()
        {
            Store.Dispatch(new FillNamesAction());
        }
    }
}
