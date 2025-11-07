using System.ComponentModel;

namespace FormyPdstawy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kolarzBindingSource.DataSource = Program.listaKolarzy;
            Refreshing();
        }


        #region Metody odpowiadajace za zdarzenia
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogKolarz dlg = new DialogKolarz(new Kolarz());
            dlg.ShowDialog();
            Pliki.zapiszPlik();
            Refreshing();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            var wybrany = (Kolarz)kolarzBindingSource.Current;
            DialogKolarz dlg = new DialogKolarz(wybrany);
            dlg.ShowDialog();
            Pliki.zapiszPlik();
            Refreshing();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            var kolarzDoUsuniecia = (Kolarz)kolarzBindingSource.Current;
            if (kolarzDoUsuniecia != null)
            {
                Program.listaKolarzy.Remove(kolarzDoUsuniecia);
                Pliki.zapiszPlik();
                Refreshing();
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            kolarzBindingSource.DataSource = Program.listaKolarzy.OrderBy(k => k.Id).Where(k => k.Nazwisko.StartsWith(txtFiltr.Text));
            Refreshing();
        }

        private void Refreshing()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kolarzBindingSource;
        }
    }
}