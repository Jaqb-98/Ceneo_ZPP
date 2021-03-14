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
    public partial class KontrolkaSzukaj : UserControl
    {
        public int myIndex;
        public KontrolkaSzukaj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void PorownajButton_Click(object sender, EventArgs e) {
            
            //this.Size = new Size(665, 200);
            //this.pictureBox1.Size = new Size(200, 190);

            var parent = this.Parent as KontrolkaSzukaj_tlo; //korzystanie z rodzica
            parent.test3(myIndex);

        }

        private void SearchControl2_Resize(object sender, EventArgs e) {

            
        }
    }
}
