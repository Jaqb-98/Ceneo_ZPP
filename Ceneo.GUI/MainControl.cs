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
    public partial class MainControl : UserControl
    {
        Form1 _parent;
        public MainControl(Form1 parent)
        {
            _parent = parent;
            InitializeComponent();
         
        }

        public MainControl()
        {
            InitializeComponent();
        }

        private void porownaj1_Click(object sender, EventArgs e)
        {
            _parent.dostemp();
        }

        private void porownaj2_Click(object sender, EventArgs e)
        {
            //compareControl1.BringToFront();
        }

        private void porownaj3_Click(object sender, EventArgs e)
        {
            //compareControl1.BringToFront();
        }
    }
}
