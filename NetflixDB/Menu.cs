using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixDB
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();    
            frm.Show();
        }

        private void serieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void tpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f=new Form3();
            f.Show();
        }
    }
}
