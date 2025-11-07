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
    public partial class frmCzlowiek : Form
    {
        Model1Container dane = new Model1Container();
        czlowiekSet mojCzlowiek;
        int _Rekord;

        public frmCzlowiek(int _rekord)
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
            button1.Visible = false;
            wiekNumericUpDown.Controls[0].Visible = false;
        }


        private void nowyRekord()
        {
            mojCzlowiek = new czlowiekSet();
        }

        private void edytujRekord()
        {
            var wynik = dane.czlowiekSet.Where(n => n.Id == _Rekord).FirstOrDefault();
            czlowiekBindingSource.DataSource = wynik;
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            if (_Rekord == -1)
            {

                mojCzlowiek.imie = imieTextBox.Text;
                mojCzlowiek.nazwisko = nazwiskoTextBox.Text;
                mojCzlowiek.wiek = (short)wiekNumericUpDown.Value;
                dane.czlowiekSet.Add(mojCzlowiek);

                czlowiekSet_bibliotekarz bb1 = new czlowiekSet_bibliotekarz();
            }
            else
            {

            }
            dane.SaveChanges();
            Close();
        }


        private void WidocznoscKontrolek(bool wartosc)
        {
            button1.Visible = !wartosc;
        }
 



        private void imieTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            button1.Visible = true;
        }

        private void nazwiskoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            button1.Visible = true;
        }

        private void wiekNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            button1.Visible = true;
        }
    }
}
