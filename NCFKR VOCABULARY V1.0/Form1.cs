using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace NCFKR_VOCABULARY_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label35.Text = "0" + saat1 + ":" + "0" + dakika1 + ":" + "0" + saniye1;
            label34.Text = "0" + saat1 + ":" + "0" + dakika1 + ":" + "0" + saniye1;
            cmb1.Text = "Seçiminizi Yapınız";

            tegk();
            kçgk();

            timer1.Start();
            timer2.Start();
        }

        #region Metodlar

        public void tekraryazdır(ArrayList x)
        {
            tx3 = int.Parse(x[tx2].ToString());
            label20.Text = tablo.Rows[tx3]["word"].ToString();
            label21.Text = tablo.Rows[tx3]["definitions"].ToString();
            
        }

        public void zaman1(Label lbl)
        {
            if (saniye2 != 59)
            {
                saniye2++;

                if (saniye2 < 10 && dakika2 < 10 && saat2 < 10)
                    lbl.Text = "0" + saat2 + ":" + "0" + dakika2 + ":" + "0" + saniye2;
                else if (saniye2 < 10 && dakika2 >= 10 && saat2 < 10)
                    lbl.Text = "0" + saat2 + ":" + dakika2 + ":" + "0" + saniye2;

                else if (saniye2 >= 10 && dakika2 >= 10 && saat2 < 10)
                    lbl.Text = "0" + saat2 + ":" + dakika2 + ":" + saniye2;

                else if (dakika2 < 10 && saat2 < 10 && saniye2 >= 10)
                    lbl.Text = "0" + saat2 + ":" + "0" + dakika2 + ":" + saniye2;
                else
                    lbl.Text = saat2 + ":" + dakika2 + ":" + saniye2;

            }

            else if (saniye2 == 59)
            {
                saniye2 = 0;

                if (dakika2 != 59)
                {
                    dakika2++;
                    if (saniye2 < 10 && dakika2 < 10 && saat2 < 10)
                        lbl.Text = "0" + saat2 + ":" + "0" + dakika2 + ":" + "0" + saniye2;

                    else if (saniye2 < 10 && dakika2 >= 10 && saat2 < 10)
                        lbl.Text = "0" + saat2 + ":" + dakika2 + ":" + "0" + saniye2;

                    else if (saniye2 >= 10 && dakika2 >= 10 && saat2 < 10)
                        lbl.Text = "0" + saat2 + ":" + dakika2 + ":" + saniye2;

                    else if (dakika2 < 10 && saat2 < 10 && saniye2 >= 10)
                        lbl.Text = "0" + saat2 + ":" + "0" + dakika2 + ":" + saniye2;
                    else
                        lbl.Text = saat2 + ":" + dakika2 + ":" + saniye2;
                }

                else if (dakika2 == 59)
                {
                    dakika2 = 0;


                    saat2++;
                    if (saniye2 < 10 && dakika2 < 10 && saat2 < 10)
                        lbl.Text = "0" + saat2 + ":" + "0" + dakika2 + ":" + "0" + saniye2;

                    else if (saniye2 < 10 && dakika2 >= 10 && saat2 < 10)
                        lbl.Text = "0" + saat2 + ":" + dakika2 + ":" + "0" + saniye2;

                    else if (saniye2 >= 10 && dakika2 >= 10 && saat2 < 10)
                        lbl.Text = "0" + saat2 + ":" + dakika2 + ":" + saniye2;

                    else if (dakika2 < 10 && saat2 < 10 && saniye2 >= 10)
                        lbl.Text = "0" + saat2 + ":" + "0" + dakika2 + ":" + saniye2;
                    else
                        lbl.Text = saat2 + ":" + dakika2 + ":" + saniye2;
                }
            }
        }

        public void zaman2(Label lbl)
        {
            if (saniye3 != 59)
            {
                saniye3++;

                if (saniye3 < 10 && dakika3 < 10 && saat3 < 10)
                    lbl.Text = "0" + saat3 + ":" + "0" + dakika3 + ":" + "0" + saniye3;
                else if (saniye3 < 10 && dakika3 >= 10 && saat3 < 10)
                    lbl.Text = "0" + saat3 + ":" + dakika3 + ":" + "0" + saniye3;

                else if (saniye3 >= 10 && dakika3 >= 10 && saat3 < 10)
                    lbl.Text = "0" + saat3 + ":" + dakika3 + ":" + saniye3;

                else if (dakika3 < 10 && saat3 < 10 && saniye3 >= 10)
                    lbl.Text = "0" + saat3 + ":" + "0" + dakika3 + ":" + saniye3;
                else
                    lbl.Text = saat3 + ":" + dakika3 + ":" + saniye3;
            }

            else if (saniye3 == 59)
            {
                saniye3 = 0;

                if (dakika3 != 59)
                {
                    dakika3++;

                    if (saniye3 < 10 && dakika3 < 10 && saat3 < 10)
                        lbl.Text = "0" + saat3 + ":" + "0" + dakika3 + ":" + "0" + saniye3;
                    else if (saniye3 < 10 && dakika3 >= 10 && saat3 < 10)
                        lbl.Text = "0" + saat3 + ":" + dakika3 + ":" + "0" + saniye3;

                    else if (saniye3 >= 10 && dakika3 >= 10 && saat3 < 10)
                        lbl.Text = "0" + saat3 + ":" + dakika3 + ":" + saniye3;

                    else if (dakika3 < 10 && saat3 < 10 && saniye3 >= 10)
                        lbl.Text = "0" + saat3 + ":" + "0" + dakika3 + ":" + saniye3;
                    else
                        lbl.Text = saat3 + ":" + dakika3 + ":" + saniye3;
                }

                else if (dakika3 == 59)
                {
                    dakika3 = 0;


                    saat3++;
                    if (saniye3 < 10 && dakika3 < 10 && saat3 < 10)
                        lbl.Text = "0" + saat3 + ":" + "0" + dakika3 + ":" + "0" + saniye3;
                    else if (saniye3 < 10 && dakika3 >= 10 && saat3 < 10)
                        lbl.Text = "0" + saat3 + ":" + dakika3 + ":" + "0" + saniye3;

                    else if (saniye3 >= 10 && dakika3 >= 10 && saat3 < 10)
                        lbl.Text = "0" + saat3 + ":" + dakika3 + ":" + saniye3;

                    else if (dakika3 < 10 && saat3 < 10 && saniye3 >= 10)
                        lbl.Text = "0" + saat3 + ":" + "0" + dakika3 + ":" + saniye3;
                    else
                        lbl.Text = saat3 + ":" + dakika3 + ":" + saniye3;
                }
            }
        }

        public void zaman3(Label lbl)
        {
            if (saniye4 != 59)
            {
                saniye4++;

                if (saniye4 < 10 && dakika4 < 10 && saat4 < 10)
                    lbl.Text = "0" + saat4 + ":" + "0" + dakika4 + ":" + "0" + saniye4;
                else if (saniye4 < 10 && dakika4 >= 10 && saat4 < 10)
                    lbl.Text = "0" + saat4 + ":" + dakika4 + ":" + "0" + saniye4;

                else if (saniye4 >= 10 && dakika4 >= 10 && saat4 < 10)
                    lbl.Text = "0" + saat4 + ":" + dakika4 + ":" + saniye4;

                else if (dakika4 < 10 && saat4 < 10 && saniye4 >= 10)
                    lbl.Text = "0" + saat4 + ":" + "0" + dakika4 + ":" + saniye4;
                else
                    lbl.Text = saat4 + ":" + dakika4 + ":" + saniye4;

            }

            else if (saniye4 == 59)
            {
                saniye4 = 0;

                if (dakika4 != 59)
                {
                    dakika4++;
                    if (saniye4 < 10 && dakika4 < 10 && saat4 < 10)
                        lbl.Text = "0" + saat4 + ":" + "0" + dakika4 + ":" + "0" + saniye4;
                    else if (saniye4 < 10 && dakika4 >= 10 && saat4 < 10)
                        lbl.Text = "0" + saat4 + ":" + dakika4 + ":" + "0" + saniye4;

                    else if (saniye4 >= 10 && dakika4 >= 10 && saat4 < 10)
                        lbl.Text = "0" + saat4 + ":" + dakika4 + ":" + saniye4;

                    else if (dakika4 < 10 && saat4 < 10 && saniye4 >= 10)
                        lbl.Text = "0" + saat4 + ":" + "0" + dakika4 + ":" + saniye4;
                    else
                        lbl.Text = saat4 + ":" + dakika4 + ":" + saniye4;
                }

                else if (dakika4 == 59)
                {
                    dakika4 = 0;


                    saat4++;
                    if (saniye4 < 10 && dakika4 < 10 && saat4 < 10)
                        lbl.Text = "0" + saat4 + ":" + "0" + dakika4 + ":" + "0" + saniye4;
                    else if (saniye4 < 10 && dakika4 >= 10 && saat4 < 10)
                        lbl.Text = "0" + saat4 + ":" + dakika4 + ":" + "0" + saniye4;

                    else if (saniye4 >= 10 && dakika4 >= 10 && saat4 < 10)
                        lbl.Text = "0" + saat4 + ":" + dakika4 + ":" + saniye4;

                    else if (dakika4 < 10 && saat4 < 10 && saniye4 >= 10)
                        lbl.Text = "0" + saat4 + ":" + "0" + dakika4 + ":" + saniye4;
                    else
                        lbl.Text = saat4 + ":" + dakika4 + ":" + saniye4;
                }
            }
        }

        public void zaman(Label lbl)
        {
            if (saniye1 != 59)
            {
                saniye1++;

                if (saniye1 < 10 && dakika1 < 10 && saat1 < 10)
                    lbl.Text = "0" + saat1 + ":" + "0" + dakika1 + ":" + "0" + saniye1;
                else if (saniye1 < 10 && dakika1 >= 10 && saat1 < 10)
                    lbl.Text = "0" + saat1 + ":" + dakika1 + ":" + "0" + saniye1;

                else if (saniye1 >= 10 && dakika1 >= 10 && saat1 < 10)
                    lbl.Text = "0" + saat1 + ":" + dakika1 + ":" + saniye1;

                else if (dakika1 < 10 && saat1 < 10 && saniye1 >= 10)
                    lbl.Text = "0" + saat1 + ":" + "0" + dakika1 + ":" + saniye1;
                else
                    lbl.Text = saat1 + ":" + dakika1 + ":" + saniye1;

            }

            else if (saniye1 == 59)
            {
                saniye1 = 0;

                if (dakika1 != 59)
                {
                    dakika1++;

                    if (saniye1 < 10 && dakika1 < 10 && saat1 < 10)
                        lbl.Text = "0" + saat1 + ":" + "0" + dakika1 + ":" + "0" + saniye1;
                    else if (saniye1 < 10 && dakika1 >= 10 && saat1 < 10)
                        lbl.Text = "0" + saat1 + ":" + dakika1 + ":" + "0" + saniye1;

                    else if (saniye1 >= 10 && dakika1 >= 10 && saat1 < 10)
                        lbl.Text = "0" + saat1 + ":" + dakika1 + ":" + saniye1;

                    else if (dakika1 < 10 && saat1 < 10 && saniye1 >= 10)
                        lbl.Text = "0" + saat1 + ":" + "0" + dakika1 + ":" + saniye1;
                    else
                        lbl.Text = saat1 + ":" + dakika1 + ":" + saniye1;
                }

                else if (dakika1 == 59)
                {
                    dakika1 = 0;


                    saat1++;

                    if (saniye1 < 10 && dakika1 < 10 && saat1 < 10)
                        lbl.Text = "0" + saat1 + ":" + "0" + dakika1 + ":" + "0" + saniye1;
                    else if (saniye1 < 10 && dakika1 >= 10 && saat1 < 10)
                        lbl.Text = "0" + saat1 + ":" + dakika1 + ":" + "0" + saniye1;

                    else if (saniye1 >= 10 && dakika1 >= 10 && saat1 < 10)
                        lbl.Text = "0" + saat1 + ":" + dakika1 + ":" + saniye1;

                    else if (dakika1 < 10 && saat1 < 10 && saniye1 >= 10)
                        lbl.Text = "0" + saat1 + ":" + "0" + dakika1 + ":" + saniye1;
                    else
                        lbl.Text = saat1 + ":" + dakika1 + ":" + saniye1;
                }
            }
        }

        public void seçimkontrol()
        {
            if (radioButton1.Checked == true)
                tekraryazdır(pas);

            else if (radioButton2.Checked == true)
                tekraryazdır(favoriler);

            else
                tekraryazdır(kelimeler);
        }

        public void kçlbltemizle()
        {
            label6.Text = "";
            label7.Text = "";
            
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
       }

        public void telbltemizle()
        {
            label20.Text = "";
            label21.Text = "";
           
            label26.Text = "";
        }

        public void dizitemizle()
        {
            kelimeler.Clear();
            pas.Clear();
            favoriler.Clear();
        }

        public void radiofalse()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        public void kelimeçek()
        {

            string yol = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Vocabulary.accdb";
            bağlantı = new OleDbConnection(yol);
            string sorgu = "select * from ingilizce";
            komut = new OleDbCommand(sorgu, bağlantı);
            adaptör = new OleDbDataAdapter(komut);
            tablo = new DataTable();

            bağlantı.Open();
            adaptör.Fill(tablo);
            bağlantı.Close();
       }

        public void yazdır()
        {
            k4 = int.Parse(kelimeler[k3].ToString());
            label6.Text = tablo.Rows[k4]["word"].ToString();
            label7.Text = tablo.Rows[k4]["definitions"].ToString();
            //label8.Text = tablo.Rows[k4]["TYPE"].ToString();
        
        }

        public void kçgk()
        {
            g3.Enabled = false;
            g4.Enabled = false;
            g5.Enabled = false;
            g6.Enabled = false;
            b26.Visible = false;
        }

        public void kçga()
        {
            g3.Enabled = true;
            g4.Enabled = true;
            g5.Enabled = true;
            g6.Enabled = true;
        }

        public void tegk()
        {
            g8.Enabled = false;
            g9.Enabled = false;
            g10.Enabled = false;
            g11.Enabled = false;
            g12.Enabled = false;
            b27.Visible = false;
        }

        public void tega()
        {
            g8.Enabled = true;
            g9.Enabled = true;
            g10.Enabled = true;
            g11.Enabled = true;
            g12.Enabled = true;
        }
        
        #endregion
        
        #region Değişkenler

        #region İnt

        int x1 = 0; // p1 de oku hareket ettircek değişken

        int x2 = 0; // p1 de kaç kelime çalışmak istiyorum ifadesinin renk değişimine yardım edicek.

        int x3 = 0; // p2 deki oku hareket ettiricek.


        int k1; // combobaxtan gelen değeri tutacak.

        int k2; // Random üretilen değeri tutacak.

        int k3=0; // Dizideki değerleri sıra ile almamızı sağlıcak.

        int k4; // Dizide tutulan değeri alacak.

        int k5 = 0; // pas değerlerini sayacak.

        int k6 = 0; // favori değerlerini sayacak.

        int top1 = 0; // Çalışılan toplam kelime sayısını tutacak.


        int süre1 = -1; // normal çalışma zamanını çalıştırır.

        int süre2 = -1; // gerçek çalışma zamanını çalıştırır.

        int süre3 = -1; // normal çalışma zamanını çalıştırır.

        int süre4 = -1; // gerçek çalışma zamanını çalıştırır.

        int t1 = -1; // pas geçme tuşunda sayı artımını yapacak.

        int t2 = -1; // favorilerde sayı artımını yapacak.

        int saniye1 = 0, saniye2 = 0, saniye3 = 0, saniye4 = 0;

        int dakika1 = 0, dakika2 = 0, dakika3 = 0, dakika4 = 0;

        int saat1 = 0, saat2 = 0, saat3 = 0, saat4 = 0;

        int tx1 = 0; // kelime çalışta seçilen kelime sayısına eşitlecek.

        int tx2 = 0; // Tekrar ette kelimelerin sırayla gelmesini sağlıcak.

        int tx3 = 0; // Tekrar ette yazdırma işleminde kelimenin sıra numarasını tutacak.


        #endregion
        
        #region DataBase

        OleDbConnection bağlantı;

        OleDbCommand komut;

        OleDbDataAdapter adaptör;

        DataTable tablo;
        
        #endregion

        #endregion
        
        #region Tanımlamalar

        Random r = new Random();

        ArrayList kelimeler = new ArrayList();

        ArrayList pas = new ArrayList();

        ArrayList favoriler = new ArrayList();
        
        #endregion

        #region Timer

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Timer 1 nesnesi Panel 1 içindeki okun sağa sola hareketini sağlar. 

            x1++;

            if (x1 % 2 == 0)
            {
                pic1.Location = new Point(3, 10);
            }

            else
                pic1.Location = new Point(13, 10);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Timer 2 nesnesi panel bir içindeki kaç kelime çalışmak istiyorsunuz yazısının rengini değiştirir.

            if (x2==0)
            {
                label2.ForeColor = Color.White;
                x2++;
            }

            else if (x2==1)
            {
                label2.ForeColor = Color.Yellow;
                x2++;
            }

            else
            {
                label2.ForeColor = Color.SkyBlue;
                x2 = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (süre1==0)
            {
                zaman(label35);

            }

            if (süre2== 0)
            {
                zaman1(label34);
            }
            
            double verim1 = saniye1 + dakika1 * 60 + saat1 * 3600;

            double verim2 = saniye2 + dakika2 * 60 + saat2 * 3600;

            double verim = (verim2 / verim1) * 100;

            label33.Text = "%" + verim.ToString();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            // Timer 4 nesnesi Panel 2 içindeki okun sağa sola hareketini sağlar. 

            x3++;

            if (x3 % 2 == 0)
            {
                pic2.Location = new Point(4, 6);
            }

            else
                pic2.Location = new Point(14, 6);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (süre3 == 0)
            {
                zaman2(label11);

            }

            if (süre4 == 0)
            {
                zaman3(label12);
            }

            double verim3 = saniye3 + dakika3 * 60 + saat3 * 3600;

            double verim4 = saniye4 + dakika4 * 60 + saat4 * 3600;

            double verimm = (verim4 / verim3) * 100;

            label9.Text = "%" + verimm.ToString();

        }

        #endregion

        #region ButonClick

        private void b9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://muratbilginerncfkr.blogspot.com.tr/");
        }

        private void b18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://muratbilginerncfkr.blogspot.com.tr/");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            t2 = 0;

            for (int i = 0; i < favoriler.Count; i++)
            {
                if (kelimeler[k3] == favoriler[i])
                {
                    MessageBox.Show("Bunu Daha Önce Eklediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t2++;
                }
            }

            if (t2 == 0)
            {
                k6++;
                lbl1.Text = k6.ToString();

                favoriler.Add(kelimeler[k3]);
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            t1 = 0;

            for (int i = 0; i < pas.Count; i++)
            {
                if (kelimeler[k3] == pas[i])
                {
                    MessageBox.Show("Bunu Daha Önce Eklediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t1++;
                }
            }

            if (t1 == 0)
            {
                k5++;

                lbl2.Text = k5.ToString();
                pas.Add(kelimeler[k3]);

                k3++;

                if (k3 < k1)
                {
                    if (k3 == k1 - 1)
                    {
                        label6.ForeColor = Color.Turquoise;
                        yazdır();
                        lbl3.Text = (k3 + 1).ToString();
                    }

                    else if (k3 % 2 == 0)
                    {
                        label6.ForeColor = Color.Black;
                        yazdır();
                        lbl3.Text = (k3 + 1).ToString();
                    }

                    else if (k3 % 2 != 0)
                    {
                        label6.ForeColor = Color.White;
                        yazdır();
                        lbl3.Text = (k3 + 1).ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Tüm Kelimelere Çalıştınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    k3--;
                }
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            k3--;
            if (k3 >= 0)
            {
                if (k3 == 0)
                {
                    label6.ForeColor = Color.Black;
                    yazdır();
                    lbl3.Text = (k3 + 1).ToString();
                }

                else if (k3 % 2 == 0)
                {
                    label6.ForeColor = Color.Yellow;
                    yazdır();
                    lbl3.Text = (k3 + 1).ToString();
                }

                else if (k3 % 2 != 0)
                {
                    label6.ForeColor = Color.White;
                    yazdır();
                    lbl3.Text = (k3 + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Daha Eski Kelime Bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                k3++;
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            k3++;

            if (k3 < k1)
            {
                if (k3 == k1 - 1)
                {
                    label6.ForeColor = Color.Black;
                    yazdır();
                    lbl3.Text = (k3 + 1).ToString();
                }

                else if (k3 % 2 == 0)
                {
                    label6.ForeColor = Color.Yellow;
                    yazdır();
                    lbl3.Text = (k3 + 1).ToString();
                }

                else if (k3 % 2 != 0)
                {
                    label6.ForeColor = Color.White;
                    yazdır();
                    lbl3.Text = (k3 + 1).ToString();
                }

            }

            else
            {
                MessageBox.Show("Tüm Kelimelere Çalıştınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                k3--;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            saniye1 = 0;
            dakika1 = 0;
            saat1 = 0;

            saniye2 = 0;
            dakika2 = 0;
            saat2 = 0;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            süre2 = 0;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            süre2 = -1;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            cmb1.Text = "Seçiminizi Yapınız";

            dizitemizle();
            kçlbltemizle();

            k5 = 0;

            p1.Enabled = true;

            timer1.Start();
            timer2.Start();

            kçgk();

            if (g6.Visible == false)
            {
                b26.Visible = true;
            }
        }

        private void b10_Click(object sender, EventArgs e)
        {
            cmb1.Text = "Seçiminizi Yapınız";

            kçlbltemizle();

            kçgk();

            if (g6.Visible == false && g2.Height == 600)
            {
                b26.Visible = true;
            }

            timer3.Stop();

            timer4.Start();

            g8.Enabled = true;

            p2.Enabled = true;

            if (pas.Count == 0)
            {
                radioButton1.Enabled = false;
            }

            else
                radioButton1.Enabled = true;

            if (favoriler.Count == 0)
            {
                radioButton2.Enabled = false;
            }

            else
                radioButton2.Enabled = true;


        }

        private void b13_Click(object sender, EventArgs e)
        {
            g6.Visible = false;
            b26.Visible = true;
        }

        private void b14_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                #region Kelime Yazılmadan Önce

                tega();

                süre3 = 0;
                süre4 = 0;

                timer5.Start();

                label20.ForeColor = Color.Yellow;

                #endregion

                #region Kelime Yazılma


                if (radioButton1.Checked == true)
                {
                    tx1 = pas.Count;
                    tekraryazdır(pas);
                }

                else if (radioButton2.Checked)
                {
                    tx1 = favoriler.Count;
                    tekraryazdır(favoriler);

                }

                else if (radioButton3.Checked == true)
                {
                    tx1 = kelimeler.Count;
                    tekraryazdır(kelimeler);
                }

                label26.Text = (tx2 + 1).ToString();

                #endregion

                #region Kelime Yazıldıktan Sonra

                p2.Enabled = false;

                timer4.Stop();

                #endregion

            }

            else
                MessageBox.Show("Herhangi bir seçeneği seçmediniz!!! Seçiminizi yapıp tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void b15_Click(object sender, EventArgs e)
        {
            tx2--;

            if (tx2 >= 0)
            {
                if (tx2 == 0)
                {
                    label20.ForeColor = Color.Yellow;

                    seçimkontrol();

                    label26.Text = (tx2 + 1).ToString();
                }

                else if (tx2 % 2 == 0)
                {
                    label20.ForeColor = Color.Black;
                    seçimkontrol();
                    label26.Text = (tx2 + 1).ToString();
                }

                else if (tx2 % 2 != 0)
                {
                    label20.ForeColor = Color.White;

                    seçimkontrol();

                    label26.Text = (tx2 + 1).ToString();
                }

            }

            else
            {
                MessageBox.Show("Tüm Kelimelere Çalıştınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tx2++;
            }

        }

        private void b16_Click(object sender, EventArgs e)
        {
            tx2++;

            if (tx2 < tx1)
            {
                if (tx2 == tx1 - 1)
                {
                    label20.ForeColor = Color.Yellow;

                    seçimkontrol();

                    label26.Text = (tx2 + 1).ToString();
                }

                else if (tx2 % 2 == 0)
                {
                    label20.ForeColor = Color.Black;
                    seçimkontrol();
                    label26.Text = (tx2 + 1).ToString();
                }

                else if (tx2 % 2 != 0)
                {
                    label20.ForeColor = Color.White;

                    seçimkontrol();

                    label26.Text = (tx2 + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Daha eski gösterilecek kelime yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tx2--;
            }
        }

        private void b17_Click(object sender, EventArgs e)
        {
            radiofalse();
            telbltemizle();
            tegk();
            tx2 = 0;

            timer5.Stop();

            cmb1.Text = "Seçiminizi Yapınız";

            tegk();
            kçgk();

            if (g6.Visible == false && g2.Height == 600)
            {
                b26.Visible = true;
            }

            p1.Enabled = true;

            timer1.Start();
            timer2.Start();
        }

        private void b19_Click(object sender, EventArgs e)
        {
            telbltemizle();

            tx2 = 0;

            tegk();

            g8.Enabled = true;

            p2.Enabled = true;

            radiofalse();

            timer4.Start();
        }

        private void b20_Click(object sender, EventArgs e)
        {
            saniye3 = 0;
            dakika3 = 0;
            saat3 = 0;

            saniye4 = 0;
            dakika4 = 0;
            saat4 = 0;
        }

        private void b21_Click(object sender, EventArgs e)
        {
            süre4 = 0;
        }

        private void b22_Click(object sender, EventArgs e)
        {
            süre4 = -1;
        }

        private void b24_Click(object sender, EventArgs e)
        {
            g12.Visible = false;
            g8.Size = new Size(590, 444);

            if (g2.Height == 444 && g8.Height == 444)
            {
                this.Size = new Size(1210, 555);
            }

            else
                this.Size = new Size(1210, 685);
        }

        private void b25_Click(object sender, EventArgs e)
        {
            g12.Visible = false;
            b27.Visible = true;
        }

        private void b26_Click_1(object sender, EventArgs e)
        {
            g6.Visible = true;
            b26.Visible = false;
        }

        private void b27_Click(object sender, EventArgs e)
        {
            g12.Visible = true;
            b27.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            g6.Visible = false;
            g2.Size = new Size(590, 444);

            if (g2.Height==444 && g8.Height==444)
            {
                this.Size = new Size(1210, 555);
            }

            else
                this.Size = new Size(1210, 685);

        }

        #endregion

        #region MouseHover

        private void b1_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Çok iyi öğrendiğiniz kelimeyi favorilerinizi ekleyebilirsiniz.";
        }

        private void b2_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Öğrenemediğiniz kelimeyi pas geçmek için kullanabilirsiniz.";
        }

        private void b3_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Bir önceki kelimeyi görmenizi sağlar.";
        }

        private void b4_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Bir sonraki kelimeyi görmenizi sağlar.";
        }

        private void b5_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Süreyi sıfırlamanızı ve süreyi yeniden başlatmanızı sağlar.";
        }

        private void b6_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Süreyi başlatır.";
        }

        private void b7_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Süreyi durdurur.";
        }

        private void b8_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Yeni kelimelerle çalışamanıza devam etmenizi sağlar.";
        }

        private void b10_MouseHover(object sender, EventArgs e)
        {
            label16.Text = "Kelime çalış bölümünü kapatıp tekrar et bölümüne geçmenizi sağlar.";
        }

        private void b11_MouseHover(object sender, EventArgs e)
        {

        }

        private void b14_MouseHover(object sender, EventArgs e)
        {
            label17.Text = "Seçim yaptığınız kelime grubu için tekrar eti başlatır.";
        }

        private void b16_MouseHover(object sender, EventArgs e)
        {
            label17.Text = "Bir sonraki kelimeyi gösterir.";
        }

        private void b15_MouseHover(object sender, EventArgs e)
        {
            label17.Text = "Bir önceki kelimeyi gösterir.";
        }

        private void b17_MouseHover(object sender, EventArgs e)
        {
            label17.Text = "Tekrar et bölümünü kapatıp.Kelime çalış bölümüne geçmenizi sağlar.";
        }

        private void b19_MouseHover(object sender, EventArgs e)
        {
            label17.Text = "Farklı bir kelime grubu seçmek yada çalıştığınızı tekrar etmek için durumu sıfırlar.";
        }

        private void b20_MouseHover(object sender, EventArgs e)
        {
            label17.Text = "Süreyi sıfırlamanızı ve süreyi yeniden başlatmanızı sağlar.";
        }

        private void b21_MouseHover(object sender, EventArgs e)
        {
            label17.Text = "Süreyi başlatır.";

        }

        private void b22_MouseHover(object sender, EventArgs e)
        {
            label17.Text = "Süreyi durdurur.";
        }


        #endregion

        #region Tek Kodlar

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                #region Dönüşte

                dizitemizle();

                k3 = 0;

                #endregion

                #region Kelime Yazılmadan Önce

                kçga();

                k1 = int.Parse(cmb1.SelectedItem.ToString());
                top1 = top1 + k1;

                kelimeçek();

                for (int i = 0; i < k1; i++)
                {
                    k2 = r.Next(0, tablo.Rows.Count);
                    kelimeler.Add(k2);

                }

                label6.ForeColor = Color.Yellow;

                yazdır();

                lbl3.Text = (k3 + 1).ToString();

                süre1 = 0;
                süre2 = 0;

                timer3.Start();



                #endregion


                #region Kelime Yazıldıktan Sonra


                p1.Enabled = false;

                timer1.Stop();

                timer2.Stop();


                #endregion

            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata ile karşılaştı program");
            }


        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region ToolStrip

        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1210, 685);

            g2.Size = new Size(590, 564);
            g6.Visible = true;
            b26.Visible = false;
        }

        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            g6.Visible = false;
            g2.Size = new Size(590, 444);

            if (g2.Height == 444 && g8.Height == 444)
            {
                this.Size = new Size(1210, 555);
            }

            else
                this.Size = new Size(1210, 685);
        }

        private void açToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1210, 685);

            g8.Size = new Size(590, 564);
            g12.Visible = true;
            b27.Visible = false;
        }

        private void kapatToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            g12.Visible = false;
            g8.Size = new Size(590, 444);

            if (g2.Height == 444 && g8.Height == 444)
            {
                this.Size = new Size(1210, 555);
            }

            else
                this.Size = new Size(1210, 685);
        }

        #endregion

    }
}
