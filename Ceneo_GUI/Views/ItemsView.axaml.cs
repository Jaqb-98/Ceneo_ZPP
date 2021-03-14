using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Ceneo_GUI.Views
{
    public class ItemsView : UserControl
    {
        public ItemsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
