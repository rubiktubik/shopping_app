using ReduxSimple;
using ShoppingApp.Order.Presentation;
using ShoppingApp.State;
using Xamarin.Forms;
using static ShoppingApp.State.Reducers;

namespace ShoppingApp
{
    public partial class App : Application
    {
        public static readonly ReduxStore<RootState> Store = new ReduxStore<RootState>(CreateReducers(),RootState.InitialState,enableTimeTravel: false);
        public App()
        {
            InitializeComponent();

            DependencyService.Register<OrderViewModel>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
