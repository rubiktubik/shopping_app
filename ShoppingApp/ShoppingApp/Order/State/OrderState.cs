namespace ShoppingApp.Order.State
{
    public record OrderState
    {
        public decimal Sum { get; set; }
        public ShoppingCartItemEntityState ShoppingCartItems { get; set; }

        public bool IsLoading { get; set; }

        public static OrderState InitialState => new OrderState()
        {
            ShoppingCartItems = new ShoppingCartItemEntityState(),
            Sum = 0m,
            IsLoading = false
        };
    }
}