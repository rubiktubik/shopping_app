using ReduxSimple;
using System.Collections.Generic;

using static ReduxSimple.Reducers;

namespace ShoppingApp.State
{
    public static class Reducers
    {
        public static IEnumerable<On<RootState>> CreateReducers()
        {
            return CombineReducers(Order.State.Reducers.GetReducers());
        }
    }
}
