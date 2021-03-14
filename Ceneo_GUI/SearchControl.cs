using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class SearchControl : UserControl
    {
        public int ileOkienek { get; set; }
        public int test2 { get; set; }
       
        public SearchControl()
        {
            InitializeComponent();
        }

        //public void Funcja()
        //{
            
        //    for (int i = 0; i < ileOkienek; i++)
        //    {

        //        ItemControl searchControl2 = new ItemControl();
        //        searchControl2.Location = new Point(6, 3 + (i * 100));

        //        searchControl2.myIndex = Controls.Count;
        //        Controls.Add(searchControl2);
                
        //    }
        //}

        private void SearchControl_Load(object sender, EventArgs e)
        {

        }

        //public void test3(int x) {
        //    Controls.Clear();
        //    int afterBigOne = 0;
        //    for (int i = 0; i < ileOkienek; i++) {

                

        //        if (i == x) {
        //            CompareControl2 compareControl2 = new CompareControl2();
        //            compareControl2.Location = new Point(6, 3 + (i * 100));
        //            compareControl2.BackColor = Color.Red;
        //            compareControl2.myIndex = Controls.Count;
        //            Controls.Add(compareControl2);
        //            afterBigOne = 100;
        //        }
        //        else {

        //            ItemControl searchControl2 = new ItemControl();
        //            searchControl2.Location = new Point(6, 3 + (i * 100) + afterBigOne);

        //            searchControl2.myIndex = Controls.Count;
        //            Controls.Add(searchControl2);
        //        }
        //    }
        //}


    }
}
