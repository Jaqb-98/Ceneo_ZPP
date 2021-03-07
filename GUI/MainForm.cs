using Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await PopulateItems();
        }


        private async Task PopulateItems()
        {
            if (flItemListPanel.Controls.Count > 0)
                flItemListPanel.Controls.Clear();

            var items = await ItemsProcessor.LoadItems(txtbSearchBar.Text);

            foreach (var item in items.ToList())
                flItemListPanel.Controls.Add(new ListItemControl(item));

            await ItemsProcessor.SaveItemsToDB(items);
        }
    }
}
