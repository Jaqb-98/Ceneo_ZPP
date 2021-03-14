using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Helper;
using System.Threading.Tasks;

namespace Ceneo_GUI.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async Task LoadItems(string searchingPhrase, int page =1)
        {
            var items = await ItemsProcessor.LoadItems(searchingPhrase, page);

        }
    }
}
