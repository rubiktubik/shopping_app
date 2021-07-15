using ReduxSimple;
using ShoppingApp.State;
using System.Collections.Generic;
using System.Reactive.Linq;
using static ReduxSimple.Effects;
using System.Linq;

namespace ShoppingApp.Order.State
{
    public static class Effects
    {
        public static Effect<RootState> GetNames = CreateEffect<RootState>(
    (store) => store.ObserveAction<FillNamesAction>()
        .Select(_ =>
            {
                return Observable.Return(new FillNamesActionSuccess(new List<string>()
                {
                    "Michael Tissen",
                    "Otto Walkes"
                }));
            }
        )
        .Switch(),
    true // indicates if the ouput of the effect should be dispatched to the store
);
    }
}
