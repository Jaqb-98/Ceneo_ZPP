using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Ceneo_GUI.Views
{
    public class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
