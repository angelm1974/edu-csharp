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
    public partial class frmKsiazka : Form
    {
        Model1Container dane = new Model1Container();
        Int32 _Rekord;
        ksiazkaSet nowaKsiazka;

        public frmKsiazka(Int32 _rekord)
        {
            InitializeComponent();
            _Rekord = _rekord;
            switch (_Rekord)
            {
                case -1:
                    nowyRekord();
                    break;
                default:
                    edytujRekord();
                    break;
            }

        }


        private void nowyRekord()
        {
            nowaKsiazka = new ksiazkaSet();
        }
        private void edytujRekord()
        {
            ksiazkaSetBindingSource.DataSource = dane.ksiazkaSet.Where(n => n.Id == _Rekord).FirstOrDefault();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            switch (_Rekord)
            {
                case -1:
                    nowaKsiazka.autor = autorTextBox.Text;
                    nowaKsiazka.tytul = tytulTextBox.Text;
                    nowaKsiazka.wydanie = (short)wydanieNumericUpDown.Value;
                    nowaKsiazka.wydawca = wydawcaTextBox.Text;
                    dane.ksiazkaSet.Add(nowaKsiazka);

                    break;
                default:
                    break;
            }

            dane.SaveChanges();
            Close();

        }


        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
