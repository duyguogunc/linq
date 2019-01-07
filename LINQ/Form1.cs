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
    public partial class Form1 : Form
    {
        int[] sayilar = { -9, -6, -5, 3, 8, 12, 25 };
        List<string> isimler = new List<string>();

        public Form1()
        {
            InitializeComponent();

            isimler.Add("Duygu");
            isimler.Add("Nergiz");
            isimler.Add("Gizem");
            isimler.Add("Caner");
            isimler.Add("Mesut");
            isimler.Add("Turgay");
        }

        private void sayilar_hepsi_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();
        }

        private void sayilar_negatif_Click(object sender, EventArgs e)
        {
            //lambda expression
            // =>  lambda

            //Foreach ile dolaşabildiğimiz generic bir interface
            IEnumerable<int> n = sayilar.Where(birsey => birsey < 0);

            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();

        }

        private void sayilar_pozitif_Click(object sender, EventArgs e)
        {
            IEnumerable<int> p = sayilar.Where(sayi => sayi > 0);
            listBox1.DataSource = null;
            listBox1.DataSource = p.ToList();
        }

        private void sayilar_cift_Click(object sender, EventArgs e)
        {
            IEnumerable<int> ciftler = sayilar.Where(x => x % 2 == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = ciftler.ToList();
        }

        private void sayilar_tek_Click(object sender, EventArgs e)
        {
            //IEnumerable<int> tekler = sayilar.Where(x => x % 2 != 0);
            IEnumerable<int> tekler = sayilar
                .Where(x => x % 2 == 1 || x % 2 == -1);

            listBox1.DataSource = null;
            listBox1.DataSource = tekler.ToList();
        }

        private void sayilar_enbuyuk_Click(object sender, EventArgs e)
        {
            int enBuyukSayi = sayilar.Max();
            MessageBox.Show(enBuyukSayi.ToString());
        }

        private void sayilar_enkucuk_Click(object sender, EventArgs e)
        {
            int enKucukSayi = sayilar.Min();
            MessageBox.Show(enKucukSayi.ToString());
        }

        private void sayilar_kactane_Click(object sender, EventArgs e)
        {
            int kacTaneSayiVar = sayilar.Length; //tercih
            int kacTaneSayiVar2 = sayilar.Count();

            MessageBox.Show(kacTaneSayiVar.ToString());
        }

        private void isim_alfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
          //  IOrderedEnumerable<string> sirali = isimler.OrderBy(x => x);
            listBox1.DataSource = isimler.OrderBy(x=> x).ToList();
            //ToList() -> List<string>
        }

        private void isim_alfabetikters_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderByDescending(x => x).ToList();
        }

        private void isim_uzunluklar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Select(x => x.Length).ToList();
            //IEnumerable<int>
        }

        private void isim_ibarindiran_Click(object sender, EventArgs e)
        {
            /*
            string sehir = "İstanbul";
            char a = sehir[0];
            string b = sehir.Substring(0, 1);
            bool c = sehir.StartsWith("İ");

            int d = sehir.IndexOf('s'); //-1 yok
            bool f = sehir.Contains("s");
             */
            listBox1.DataSource = null;
           listBox1.DataSource = isimler.Where(x => x.Contains('i') || x.Contains('İ'));
        }

        private void isim_nilebaslayan_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.StartsWith("n") || x.StartsWith("N"));
        }

        private void siparis_hepsi_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            //tek bir alan seçilecekse 
            //  var gorunen = orders.Select(satir => satir.EmployeeID);

            //birden fazla alan seçilecekse
            var gorunen = orders.Select(satir => new {
                SiparisNo = satir.OrderID,
                Tarih = satir.OrderDate,
                Musteri = satir.Customer.ContactName
            });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gorunen.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders
                .Select(x => x.OrderDate)
                .ToList();
        }

        private void ilk5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            dataGridView1.DataSource = null;
            //orders.Skip(10).Take(5)
            //10 kayıt atla sıradaki 5 kaydı al
            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void son5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders
                .OrderByDescending(x => x.OrderID)
                .Take(5)
                .Select(x=> new
                {
                    x.OrderID,
                    x.Customer.ContactName,
                    x.OrderDate
                })
                .ToList();
        }

        private void yangwang_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            var filter = orders
                .Where(x =>
                x.Customer.ContactName == "Yang Wang")
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filter;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            int sayi = orders.Count; //tercih
            int sayi2 = orders.Count();
            MessageBox.Show(sayi.ToString());
        }
    }
}
