using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Helper;

namespace GUI
{
    public partial class ListItemControl : UserControl
    {
        #region Constructors
        public ListItemControl(Item item)
        {

            InitializeComponent();

            Item = new Item();
            Item.ProductName = item.ProductName;
            Item.Price = item.Price;
            Item.Category = item.Category;
            Item.Image = item.Image;

            SetValues();

        }

        public ListItemControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties

        public Item Item { get; set; }

        #endregion

        private void SetValues()
        {
            lblItemCategory.Text = Item.Category;
            lblItemName.Text = Item.ProductName;
            lblItemPrice.Text = Item.Price.ToString();

            if (Item.Image != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("http:").Append(Item.Image);

                pbItemImage.LoadAsync(sb.ToString());
            }
        }

    }
}
