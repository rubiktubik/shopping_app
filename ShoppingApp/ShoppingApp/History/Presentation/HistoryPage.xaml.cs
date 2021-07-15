using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingApp.History.Presentation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
            var viewModel = DependencyService.Resolve<HistoryViewModel>();
            BindingContext = viewModel;
        }
    }
}