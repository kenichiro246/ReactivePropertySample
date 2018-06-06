using System;
using System.Reactive.Linq;
using Reactive.Bindings;

namespace ReactivePropertySample
{
    class MainViewModel
    {
        public ReactiveProperty<long> Counter { get; }
        public ReactiveProperty<string> InputText { get; }
        public ReactiveProperty<string> OutputText { get; }

        public MainViewModel()
        {
            Counter = Observable.Interval(TimeSpan.FromSeconds(1)).ToReactiveProperty();

            InputText = new ReactiveProperty<string>("");
            OutputText= this.InputText
                .Select(x => x.ToUpper())
                .ToReactiveProperty();
        }
    }
}
