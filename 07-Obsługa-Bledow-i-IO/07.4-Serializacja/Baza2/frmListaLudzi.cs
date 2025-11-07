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
    public partial class frmListaLudzi : Form
    {
        Model1Container dane; 
        public frmListaLudzi()
        {
            InitializeComponent();
            PobierzDane();
        }
        private void PobierzDane()
        {
            dane = new Model1Container();
            czlowiekSetBindingSource.DataSource = dane.czlowiekSet.ToList();
        }

        #region CRUD

        private void btnNowy_Click(object sender, EventArgs e)
        {
            frmCzlowiek frm = new frmCzlowiek(-1);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            PobierzDane();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Int32 mojId = (Int32)czlowiekSetDataGridView.CurrentRow.Cells[0].Value;
            frmCzlowiek frm = new frmCzlowiek(mojId);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            PobierzDane();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show("Czy chcesz usunąć rekord?", ProductName, MessageBoxButtons.YesNo);
            if (dialogRes == DialogResult.Yes)
            {
                Int32 mojId = (Int32)czlowiekSetDataGridView.CurrentRow.Cells[0].Value;
                czlowiekSet do_usuniecia = dane.czlowiekSet.Where(n => n.Id == mojId).FirstOrDefault();
                dane.czlowiekSet.Remove(do_usuniecia);
                dane.SaveChanges();
                PobierzDane();
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


    }

}
