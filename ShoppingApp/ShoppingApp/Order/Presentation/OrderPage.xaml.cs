
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingApp.Order.Presentation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
            var viewModel = DependencyService.Resolve<OrderViewModel>();
            BindingContext = viewModel;
        }

        private void ContentPage_Disappearing(object sender, System.EventArgs e)
        {
            if (BindingContext is OrderViewModel viewModel)
            {
                viewModel.Dispose();
            }
        }

        private void ShoppingCartButton_Clicked(object sender, System.EventArgs e)
        {
            if (BindingContext is OrderViewModel viewModel)
            {
                viewModel.GetNamesCommand();
            }
        }
    }
}