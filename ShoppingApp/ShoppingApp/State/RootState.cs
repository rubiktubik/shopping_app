using ShoppingApp.Order.State;

namespace ShoppingApp.State
{
    public record RootState
    {
        public OrderState Order { get; set; }
        public static RootState InitialState => new RootState()
        {
            Order = OrderState.InitialState
        };
    }
}
