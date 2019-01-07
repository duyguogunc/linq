using LINQ.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form2 : Form
    {
         List<Personel> liste = new List<Personel>();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liste.Add(new Personel());

            string psayi = liste.Count.ToString();
            lbl_personel_sayi.Text = Resources.sablon1.Replace("0", psayi);

            string ort = liste.Average(x => x.Maas).ToString("C");
            lbl_ort_maas.Text = Resources.sablon2.Replace("0", ort);

            Personel p1 = liste.Last();

            lbl_yas.Text = Resources.sablon3.Replace("0", p1.Yas.ToString());
            lbl_maas.Text = Resources.sablon4.Replace("0", p1.Maas.ToString());

        }
    }
}
