using Avalonia.Controls;
using Explorer.Shared.ViewModels;

namespace Explorer.Avalonia.UI.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}