using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Helper;

namespace GUI
{
    public partial class ItemControl : UserControl
    {
        #region Properties
        public Item Item { get; set; }
        #endregion


        #region Constructors
        public ItemControl()
        {
            InitializeComponent();
        }
        public ItemControl(Item item)
        {

            InitializeComponent();

            Item = new Item();
            Item.ProductName = item.ProductName;
            Item.Price = item.Price;
            Item.Category = item.Category;
            Item.Image = item.Image;
            Item.Params = item.Params;
            Item.ShopUrl = item.ShopUrl;

            
            SetValues();
        }

        #endregion


        #region Methods
        private void SetValues()
        {
            txtbItemCategory.Text = $"Kategoria: {Item.Category}";
            txtbItemName.Text = Item.ProductName;
            txtPrice.Text = $"{Item.Price.ToString()} zł";

            if (Item.Params != null)
            {
                foreach (var item in Item.Params)
                {

                    richTextBoxParameters.Text += $"{item.Key}: {item.Value}\n";
                }
            }

            if (Item.Image != null)
            {
                var sb = new StringBuilder();
                sb.Append("http:").Append(Item.Image);
                try
                {
                    pbItemImage.LoadAsync(sb.ToString());

                }
                catch (Exception)
                {

                    pbItemImage.Image = Ceneo.GUI.Properties.Resources.image_placeholder;
                }
            }
        }

        #endregion


        #region Events

        private void GoToShopButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Item.ShopUrl))
                OpenBrowser(Item.ShopUrl);

        }

        private void OpenBrowser(string url)
        {

            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void SearchControl2_Resize(object sender, EventArgs e)
        {


        }
        #endregion

        private void ItemControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            txtbItemCategory.BackColor = Color.Silver;
            txtbItemName.BackColor = Color.Silver;
            txtPrice.BackColor = Color.Silver;
            richTextBoxParameters.BackColor = Color.Silver;
        }

        private void ItemControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            txtbItemCategory.BackColor = Color.White;
            txtbItemName.BackColor = Color.White;
            txtPrice.BackColor = Color.White;
            richTextBoxParameters.BackColor = Color.White;
        }

      

   
    }
}
