using Reactive.Bindings;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;

namespace ReactivePropertyStackOverflow;

public partial class MainWindow
{
    private readonly ObservableCollection<int> _source = new();
    private readonly ReadOnlyReactiveCollection<int> _target;
        
    public MainWindow()
    {
        InitializeComponent();
        
        _target = _source.ToReadOnlyReactiveCollection(x => x);
    }
    
    private void Button_OnClick(object sender, RoutedEventArgs e)
    {
        Task.Run(() =>
        {
            for (var i = 0; i != 10000; ++i)
            {
                _source.Add(i);
            }
        });
    }
}