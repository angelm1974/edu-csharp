using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class listaKredytobiorcow : Form
    {
        public listaKredytobiorcow()
        {
            InitializeComponent();
            pobierz_Liste();
        }
        void pobierz_Liste()
        {
            List<danePliku> mojeDane = new List<danePliku>();
            string[] files = Directory.GetFiles(@"D:\Python_folders", "*.txt");

            foreach (var item in files)
            {
                string dane = item.Substring(0, item.IndexOf('_'));
                mojeDane.Add(new danePliku() { Imie = dane,Nazwisko="n" });
                
            }
            dataGridView1.DataSource = mojeDane.ToList();

        }
    }

    class danePliku{
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }

}
