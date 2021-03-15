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
        #region Private variables

        private ItemControl[] _itemControls;
        private List<Item> _items;
        private int _page = 1;

        #endregion

        #region Constructors
        /// <summary>
        /// Main form constructor with initialization of Http Client
        /// </summary>
        /// 
        public MainForm()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
        }
        #endregion

        #region Buttons Clicks
        private void KrokietButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// btn Search event calls backgroundWorker.RunWorkerAsync()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_click(object sender, EventArgs e)
        {
            _page = 1;
            backgroundWorker1.RunWorkerAsync();
        }

        #endregion


        /// <summary>
        /// Loads items from API and creates controls.
        /// </summary>
        /// <returns></returns>
        private  void CreateControls()
        {

            var items =  ItemsProcessor.LoadItems(txtbSearchBar.Text, _page).Result;

            _items = items;

            var itemControls = new List<ItemControl>();

            foreach (var item in items)
                itemControls.Add(new ItemControl(item));

            _itemControls = itemControls.ToArray();


        }


        /// <summary>
        /// Populates flowLayoutPanel with ItemControls
        /// </summary>
        /// <param name="itemControls"></param>
        private void PopulatePanelWithControls(ItemControl[] itemControls)
        {
            if (flItemListPanel.Controls.Count > 0)
                flItemListPanel.Controls.Clear();

            flItemListPanel.Controls.AddRange(itemControls);
        }

        /// <summary>
        /// Creates controls in backgroundworker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CreateControls();
        }

        /// <summary>
        /// Populates panel with controls and upserts items to DB after backgroundworker_DoWork is completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_itemControls != null)
            {

                PopulatePanelWithControls(_itemControls);
                await ItemsProcessor.SaveItemsToDB(_items);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _page++;
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_page >= 2)
            {
                _page--;
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
