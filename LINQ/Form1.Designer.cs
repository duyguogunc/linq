namespace LINQ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siparis_hepsi = new System.Windows.Forms.Button();
            this.sayilar_hepsi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sayilar_negatif = new System.Windows.Forms.Button();
            this.sayilar_pozitif = new System.Windows.Forms.Button();
            this.sayilar_cift = new System.Windows.Forms.Button();
            this.sayilar_tek = new System.Windows.Forms.Button();
            this.sayilar_enbuyuk = new System.Windows.Forms.Button();
            this.sayilar_enkucuk = new System.Windows.Forms.Button();
            this.sayilar_kactane = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.isim_alfabetik = new System.Windows.Forms.Button();
            this.isim_alfabetikters = new System.Windows.Forms.Button();
            this.isim_uzunluklar = new System.Windows.Forms.Button();
            this.isim_ibarindiran = new System.Windows.Forms.Button();
            this.isim_nilebaslayan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // siparis_hepsi
            // 
            this.siparis_hepsi.Location = new System.Drawing.Point(12, 121);
            this.siparis_hepsi.Name = "siparis_hepsi";
            this.siparis_hepsi.Size = new System.Drawing.Size(210, 48);
            this.siparis_hepsi.TabIndex = 1;
            this.siparis_hepsi.Text = "Tüm Siparişler";
            this.siparis_hepsi.UseVisualStyleBackColor = true;
            this.siparis_hepsi.Click += new System.EventHandler(this.siparis_hepsi_Click);
            // 
            // sayilar_hepsi
            // 
            this.sayilar_hepsi.Location = new System.Drawing.Point(12, 12);
            this.sayilar_hepsi.Name = "sayilar_hepsi";
            this.sayilar_hepsi.Size = new System.Drawing.Size(210, 48);
            this.sayilar_hepsi.TabIndex = 2;
            this.sayilar_hepsi.Text = "Tüm Sayılar";
            this.sayilar_hepsi.UseVisualStyleBackColor = true;
            this.sayilar_hepsi.Click += new System.EventHandler(this.sayilar_hepsi_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tüm İsimler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // sayilar_negatif
            // 
            this.sayilar_negatif.Location = new System.Drawing.Point(228, 13);
            this.sayilar_negatif.Name = "sayilar_negatif";
            this.sayilar_negatif.Size = new System.Drawing.Size(102, 48);
            this.sayilar_negatif.TabIndex = 4;
            this.sayilar_negatif.Text = "Negatif";
            this.sayilar_negatif.UseVisualStyleBackColor = true;
            this.sayilar_negatif.Click += new System.EventHandler(this.sayilar_negatif_Click);
            // 
            // sayilar_pozitif
            // 
            this.sayilar_pozitif.Location = new System.Drawing.Point(336, 13);
            this.sayilar_pozitif.Name = "sayilar_pozitif";
            this.sayilar_pozitif.Size = new System.Drawing.Size(93, 48);
            this.sayilar_pozitif.TabIndex = 5;
            this.sayilar_pozitif.Text = "Pozitif";
            this.sayilar_pozitif.UseVisualStyleBackColor = true;
            this.sayilar_pozitif.Click += new System.EventHandler(this.sayilar_pozitif_Click);
            // 
            // sayilar_cift
            // 
            this.sayilar_cift.Location = new System.Drawing.Point(438, 12);
            this.sayilar_cift.Name = "sayilar_cift";
            this.sayilar_cift.Size = new System.Drawing.Size(80, 48);
            this.sayilar_cift.TabIndex = 6;
            this.sayilar_cift.Text = "Çift";
            this.sayilar_cift.UseVisualStyleBackColor = true;
            this.sayilar_cift.Click += new System.EventHandler(this.sayilar_cift_Click);
            // 
            // sayilar_tek
            // 
            this.sayilar_tek.Location = new System.Drawing.Point(524, 12);
            this.sayilar_tek.Name = "sayilar_tek";
            this.sayilar_tek.Size = new System.Drawing.Size(63, 48);
            this.sayilar_tek.TabIndex = 7;
            this.sayilar_tek.Text = "Tek";
            this.sayilar_tek.UseVisualStyleBackColor = true;
            this.sayilar_tek.Click += new System.EventHandler(this.sayilar_tek_Click);
            // 
            // sayilar_enbuyuk
            // 
            this.sayilar_enbuyuk.Location = new System.Drawing.Point(593, 12);
            this.sayilar_enbuyuk.Name = "sayilar_enbuyuk";
            this.sayilar_enbuyuk.Size = new System.Drawing.Size(133, 48);
            this.sayilar_enbuyuk.TabIndex = 8;
            this.sayilar_enbuyuk.Text = "En büyük";
            this.sayilar_enbuyuk.UseVisualStyleBackColor = true;
            this.sayilar_enbuyuk.Click += new System.EventHandler(this.sayilar_enbuyuk_Click);
            // 
            // sayilar_enkucuk
            // 
            this.sayilar_enkucuk.Location = new System.Drawing.Point(732, 12);
            this.sayilar_enkucuk.Name = "sayilar_enkucuk";
            this.sayilar_enkucuk.Size = new System.Drawing.Size(133, 48);
            this.sayilar_enkucuk.TabIndex = 9;
            this.sayilar_enkucuk.Text = "En küçük";
            this.sayilar_enkucuk.UseVisualStyleBackColor = true;
            this.sayilar_enkucuk.Click += new System.EventHandler(this.sayilar_enkucuk_Click);
            // 
            // sayilar_kactane
            // 
            this.sayilar_kactane.Location = new System.Drawing.Point(869, 12);
            this.sayilar_kactane.Name = "sayilar_kactane";
            this.sayilar_kactane.Size = new System.Drawing.Size(133, 48);
            this.sayilar_kactane.TabIndex = 10;
            this.sayilar_kactane.Text = "Kaç Tane";
            this.sayilar_kactane.UseVisualStyleBackColor = true;
            this.sayilar_kactane.Click += new System.EventHandler(this.sayilar_kactane_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(12, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 207);
            this.listBox1.TabIndex = 11;
            // 
            // isim_alfabetik
            // 
            this.isim_alfabetik.Location = new System.Drawing.Point(228, 67);
            this.isim_alfabetik.Name = "isim_alfabetik";
            this.isim_alfabetik.Size = new System.Drawing.Size(125, 48);
            this.isim_alfabetik.TabIndex = 12;
            this.isim_alfabetik.Text = "Alfabetik";
            this.isim_alfabetik.UseVisualStyleBackColor = true;
            this.isim_alfabetik.Click += new System.EventHandler(this.isim_alfabetik_Click);
            // 
            // isim_alfabetikters
            // 
            this.isim_alfabetikters.Location = new System.Drawing.Point(359, 67);
            this.isim_alfabetikters.Name = "isim_alfabetikters";
            this.isim_alfabetikters.Size = new System.Drawing.Size(181, 48);
            this.isim_alfabetikters.TabIndex = 13;
            this.isim_alfabetikters.Text = "Alfabetik Ters";
            this.isim_alfabetikters.UseVisualStyleBackColor = true;
            this.isim_alfabetikters.Click += new System.EventHandler(this.isim_alfabetikters_Click);
            // 
            // isim_uzunluklar
            // 
            this.isim_uzunluklar.Location = new System.Drawing.Point(546, 67);
            this.isim_uzunluklar.Name = "isim_uzunluklar";
            this.isim_uzunluklar.Size = new System.Drawing.Size(144, 48);
            this.isim_uzunluklar.TabIndex = 14;
            this.isim_uzunluklar.Text = "Uzunluklar";
            this.isim_uzunluklar.UseVisualStyleBackColor = true;
            this.isim_uzunluklar.Click += new System.EventHandler(this.isim_uzunluklar_Click);
            // 
            // isim_ibarindiran
            // 
            this.isim_ibarindiran.Location = new System.Drawing.Point(696, 66);
            this.isim_ibarindiran.Name = "isim_ibarindiran";
            this.isim_ibarindiran.Size = new System.Drawing.Size(163, 48);
            this.isim_ibarindiran.TabIndex = 15;
            this.isim_ibarindiran.Text = "i barındıran";
            this.isim_ibarindiran.UseVisualStyleBackColor = true;
            this.isim_ibarindiran.Click += new System.EventHandler(this.isim_ibarindiran_Click);
            // 
            // isim_nilebaslayan
            // 
            this.isim_nilebaslayan.Location = new System.Drawing.Point(865, 66);
            this.isim_nilebaslayan.Name = "isim_nilebaslayan";
            this.isim_nilebaslayan.Size = new System.Drawing.Size(199, 48);
            this.isim_nilebaslayan.TabIndex = 16;
            this.isim_nilebaslayan.Text = "N ile başlayan";
            this.isim_nilebaslayan.UseVisualStyleBackColor = true;
            this.isim_nilebaslayan.Click += new System.EventHandler(this.isim_nilebaslayan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sadece Tarihler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(453, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 48);
            this.button4.TabIndex = 18;
            this.button4.Text = "İlk 5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ilk5_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(546, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 48);
            this.button5.TabIndex = 19;
            this.button5.Text = "Son 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.son5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(639, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 48);
            this.button6.TabIndex = 20;
            this.button6.Text = "Yang Wang";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.yangwang_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(814, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 48);
            this.button7.TabIndex = 21;
            this.button7.Text = "Sipariş sayısı";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 405);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.isim_nilebaslayan);
            this.Controls.Add(this.isim_ibarindiran);
            this.Controls.Add(this.isim_uzunluklar);
            this.Controls.Add(this.isim_alfabetikters);
            this.Controls.Add(this.isim_alfabetik);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sayilar_kactane);
            this.Controls.Add(this.sayilar_enkucuk);
            this.Controls.Add(this.sayilar_enbuyuk);
            this.Controls.Add(this.sayilar_tek);
            this.Controls.Add(this.sayilar_cift);
            this.Controls.Add(this.sayilar_pozitif);
            this.Controls.Add(this.sayilar_negatif);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sayilar_hepsi);
            this.Controls.Add(this.siparis_hepsi);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button siparis_hepsi;
        private System.Windows.Forms.Button sayilar_hepsi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sayilar_negatif;
        private System.Windows.Forms.Button sayilar_pozitif;
        private System.Windows.Forms.Button sayilar_cift;
        private System.Windows.Forms.Button sayilar_tek;
        private System.Windows.Forms.Button sayilar_enbuyuk;
        private System.Windows.Forms.Button sayilar_enkucuk;
        private System.Windows.Forms.Button sayilar_kactane;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button isim_alfabetik;
        private System.Windows.Forms.Button isim_alfabetikters;
        private System.Windows.Forms.Button isim_uzunluklar;
        private System.Windows.Forms.Button isim_ibarindiran;
        private System.Windows.Forms.Button isim_nilebaslayan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

