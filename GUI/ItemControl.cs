using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;

namespace test
{
    public partial class ItemControl : UserControl
    {
        public int myIndex;
        public ItemControl(Item item)
        {
            InitializeComponent();

            Item = new Item();
            Item.ProductName = item.ProductName;
            Item.Price = item.Price;
            Item.Category = item.Category;
            Item.Image = item.Image;

            SetValues();
        }


        public ItemControl()
        {
            InitializeComponent();
        }

        public Item Item  { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonLog_Click(object sender, EventArgs e) {
            
            //this.Size = new Size(665, 200);
            //this.pictureBox1.Size = new Size(200, 190);

            var parent = this.Parent as SearchControl; //korzystanie z rodzica
            parent.test3(myIndex);

        }

        private void SearchControl2_Resize(object sender, EventArgs e) {

            
        }

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
