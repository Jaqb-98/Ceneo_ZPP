using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KrokietButton_Click(object sender, EventArgs e)
        {
            mainControl1.BringToFront();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            loginControl1.BringToFront();
        }

        private void szukaj_click(object sender, EventArgs e)
        {
            searchControl2.Controls.Clear();
            searchControl2.ileOkienek = Int32.Parse(textBox2.Text);
            searchControl2.BringToFront();
            searchControl2.Funcja();
        }

        public void dostemp()
        {
            compareControl1.Controls.Clear();
            compareControl1.BringToFront();
            compareControl1.PokazNajlepszy();
        }
    }
}
