using Reactive.Bindings;
using Reactive.Bindings.Schedulers;
using System.Windows;

namespace ReactivePropertyStackOverflow;

public partial class App
{
    private void App_OnStartup(object sender, StartupEventArgs e)
    {
        ReactivePropertyScheduler.SetDefault(new ReactivePropertyWpfScheduler(Dispatcher));
    }
}