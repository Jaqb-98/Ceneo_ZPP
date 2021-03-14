using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Ceneo_GUI.Views.Controls
{
    public class ItemControl : UserControl
    {
        public ItemControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
