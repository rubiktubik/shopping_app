namespace ShoppingApp.Order.Domain
{
    public record ProductId(int Value);
    public record ShoppingCartItemId(int Value);
    public record Product(ProductId Id,decimal Price,string Description);
    public record ShoppingCartItem(ShoppingCartItemId Id,Product Product,int Amount);
}
