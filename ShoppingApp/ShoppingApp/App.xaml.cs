using ReduxSimple;
using ShoppingApp.State;
using Xamarin.Forms;
using static ShoppingApp.State.Reducers;

namespace ShoppingApp
{
    public partial class App : Application
    {
        public static readonly ReduxStore<RootState> Store = new ReduxStore<RootState>(CreateReducers(),enableTimeTravel: false);
        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
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
