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
    public partial class CompareControl : UserControl
    {
        public CompareControl()
        {
            InitializeComponent();
        }

        public void PokazNajlepszy()
        {
            Controls.Clear();
            CompareControl2 compareControl2 = new CompareControl2();
            compareControl2.Location = new Point(6, 3);
            compareControl2.BringToFront();
            Controls.Add(compareControl2);
        }

        private void CompareControl_Load(object sender, EventArgs e)
        {

        }
    }
}
