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

            ProductName = item.ProductName;
            Price = item.Price;
            Category = item.Category;
            Image = item.Image;

        }

        public ListItemControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties

        //public Item Item { get; set; }

        private string _productName;
        private string _category;
        private decimal _price;
        private string _image;

        //[Category("Custom Props")]
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; lblItemName.Text = value; }
        }


        //[Category("Custom Props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; lblItemCategory.Text = value; }
        }


        //[Category("Custom Props")]
        public decimal Price
        {
            get { return _price; }
            set { _price = value; lblItemPrice.Text = value.ToString(); }
        }


        //[Category("Custom Props")]
        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                if (value != null)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("http:").Append(value);

                    pbItemImage.LoadAsync(sb.ToString());
                }
            }
        }


        #endregion



    }
}
