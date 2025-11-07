using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baza2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaLudzi frm = new frmListaLudzi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmListaKsiazek frm = new frmListaKsiazek();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
