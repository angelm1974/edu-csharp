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
    public partial class frmListaKsiazek : Form
    {
        public frmListaKsiazek()
        {
            InitializeComponent();
            PobierzDane();
        }

        Model1Container dane;
        
        private void PobierzDane()
        {
            dane = new Model1Container();

            ksiazkaSetBindingSource.DataSource = dane.ksiazkaSet.ToList();
            
        }
        #region CRUD

        private void btnNowy_Click(object sender, EventArgs e)
        {
            frmKsiazka frm = new frmKsiazka(-1);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            PobierzDane();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            Int32 mojId = (Int32)ksiazkaSetDataGridView.CurrentRow.Cells[0].Value;
            frmKsiazka frm = new frmKsiazka(mojId);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            PobierzDane();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show("Czy chcesz usunąć rekord?", ProductName, MessageBoxButtons.YesNo);
            if (dialogRes == DialogResult.Yes)
            {
                Int32 mojId = (Int32)ksiazkaSetDataGridView.CurrentRow.Cells[0].Value;
                ksiazkaSet do_usuniecia = dane.ksiazkaSet.Where(n => n.Id == mojId).FirstOrDefault();
                dane.ksiazkaSet.Remove(do_usuniecia);
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
