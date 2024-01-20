using Avalonia.Controls;

namespace TopDownRPD.NativeAvalonia.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var test = TryGetPlatformHandle();
    }
}
