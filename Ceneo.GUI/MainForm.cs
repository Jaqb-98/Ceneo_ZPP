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

        private List<ItemControl> _itemControls = new List<ItemControl>();
        private List<ItemControl>[] _PagedItemControls = new List<ItemControl>[10];
        private List<Item> _items;
        private int _page = 1;
        private int _subpage = 0;
        private int _maxSubPage;
        private int _perPage = 10;
        private int _pageCount = 1;


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
            UpdatePageLabel();
        }
        #endregion

        #region Buttons Clicks
        private void KrokietButton_Click(object sender, EventArgs e)
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
            _pageCount = 1;
            _subpage = 0;
            _PagedItemControls = new List<ItemControl>[10];
            WorkInBackground();
            UpdatePageLabel();
        }

        #endregion


        /// <summary>
        /// Loads items from API and creates controls.
        /// </summary>
        /// <returns></returns>
        private void CreateControls()
        {
            List<Item> items;
            try
            {
                items = GetItems();
            }
            catch (Exception)
            {
                items = GetItems(true);
            }

            _items = items;
            _maxSubPage = (int)Math.Ceiling((double)_items.Count / _perPage) - 1;


            CreatePageControls(_subpage, _perPage);

        }

        private void CreatePageControls(int subpage, int perPage)
        {
            var itemControls = new List<ItemControl>();
            foreach (var item in GetPage(_items, subpage, perPage))
            {
                var newItemControl = new ItemControl(item);
                itemControls.Add(newItemControl); ;
            }

            _PagedItemControls[_subpage] = itemControls;
        }



        private List<Item> GetItems(bool fromDB = false)
        {
            List<Item> items = !fromDB
                ? ItemsProcessor.LoadItems(txtbSearchBar.Text, _page).Result
                : ItemsProcessor.LoadItemsFromDB(txtbSearchBar.Text).Result;
            return items;
        }




        /// <summary>
        /// Populates flowLayoutPanel with ItemControls
        /// </summary>
        /// <param name="itemControls"></param>
        private void PopulatePanelWithControls()
        {
            if (flItemListPanel.Controls.Count > 0)
                flItemListPanel.Controls.Clear();


            flItemListPanel.Controls.AddRange(_PagedItemControls[_subpage].ToArray());

            

            for (int i = 0; i < flItemListPanel.Controls.Count; i++)
            {
                flItemListPanel.Controls[i].Dock = DockStyle.None;
                flItemListPanel.Controls[i].Width = flItemListPanel.DisplayRectangle.Width - flItemListPanel.Controls[i].Margin.Horizontal;
            }
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

        private void WorkInBackground()
        {
            btnSearch.Enabled = false;
            btnNextPage.Enabled = false;
            btnPreviousPage.Enabled = false;

            spinningCircles1.Visible = true;

            backgroundWorker1.RunWorkerAsync();

        }

        /// <summary>
        /// Populates panel with controls and upserts items to DB after backgroundworker_DoWork is completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSearch.Enabled = true;
            btnNextPage.Enabled = true;
            btnPreviousPage.Enabled = true;

            spinningCircles1.Visible = false;

            if (_itemControls != null)
            {
                PopulatePanelWithControls();
                await ItemsProcessor.SaveItemsToDB(_items);
            }


        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_subpage + 1 <= _maxSubPage)
                _subpage++;
            else
            {
                _subpage = 0;
                _page++;
                _PagedItemControls = new List<ItemControl>[3];
            }

            if (_PagedItemControls[_subpage] == null)
                WorkInBackground();
            else
                PopulatePanelWithControls();

            _pageCount++;
            UpdatePageLabel();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_subpage > 0)
                _subpage--;
            else
            {
                if (_page >= _maxSubPage)
                {
                    _page--;
                    _subpage = _maxSubPage;
                    _PagedItemControls = new List<ItemControl>[_maxSubPage + 1];
                }
            }

            if (_PagedItemControls[_subpage] == null)
                WorkInBackground();
            else
                PopulatePanelWithControls();

            _pageCount--;
            UpdatePageLabel();
        }

        private IList<Item> GetPage(IList<Item> list, int page, int pageSize)
        {
            return list.Skip(page * pageSize).Take(pageSize).ToList();
        }

        private void UpdatePageLabel()
        {
            lblPageNumber.Text = _pageCount.ToString();
        }

   
    }


}
