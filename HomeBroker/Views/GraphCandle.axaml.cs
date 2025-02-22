using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HomeBroker.ViewModels.Graph;

namespace HomeBroker.Views;

public partial class GraphCandle : UserControl
{
    public GraphCandle()
    {
        InitializeComponent();
        DataContext = new GraphViewModel();
    }
}