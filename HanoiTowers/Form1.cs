using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace HanoiTowers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SQLiteConnection connection;

        string ad;
        int disksayi;
        int yas;
        int hamle;
        int süre;
        public static bool formAcikMi = false;
        Random rasgeleSayi = new Random();
        int hamleSayisi = 0;
        int buttonKonumX;
        int buttonKonumY;
        int buttonGenislik;
        bool gidilebilirMi;
        Button b;
        Point buttonKonum;
        bool oyunBitti = false;
        int buttonSayisi;
        int saniye = 0;

        private void tablogoster()
        {
            try
            {
                string cs = $"URI=file:{AppDomain.CurrentDomain.BaseDirectory}\\Test.db";
                connection = new SQLiteConnection(cs);
                connection.Open();

                var cmd = new SQLiteCommand(connection);
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS sıralama(id INTEGER PRIMARY KEY,kullanici_adi TEXT, yas INT, disk_sayi INT, hamle INT, sure INT)";
                cmd.ExecuteNonQuery();

                //SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM sıralama", connection); 
                SQLiteDataAdapter da = new SQLiteDataAdapter("select kullanici_adi, yas, disk_sayi, hamle, sure from sıralama", connection);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hanoi Kule Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void veriekle()
        {
            try
            {
                var cmd = new SQLiteCommand(connection);
                cmd.CommandText = "INSERT INTO sıralama(kullanici_adi,yas,disk_sayi,hamle,sure) VALUES('" + ad + "'," + yas + "," + disksayi + "," + hamle + "," + süre + ");";
                cmd.ExecuteNonQuery();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select kullanici_adi, yas, disk_sayi, hamle, sure from sıralama", connection);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void butonlar_MouseDown(object sender, MouseEventArgs e)
        {
            b = sender as Button;
            buttonKonumX = b.Location.X;
            buttonKonumY = b.Location.Y;
            buttonKonum = b.Location;
            buttonGenislik = b.Width;

            bool gidebilirmi = true;
            foreach (Button panelButton in b.Parent.Controls)
            {
                if (buttonGenislik > panelButton.Width)
                    gidebilirmi = false;
            }
            if (gidebilirmi == true)
            {
                DragDropEffects DDE = DragDropEffects.All;
                panel1.DoDragDrop(b, DDE);
            }

        }
        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Panel HedefP = sender as Panel;
            if (e.Data.GetData(typeof(Button)) is Button)
            {
                Button SuruklenenButton = (Button)e.Data.GetData(typeof(Button));
                int sayac = 1;
                gidilebilirMi = true;
                foreach (Button pButton in HedefP.Controls)
                {
                    if (pButton.Width < buttonGenislik)
                        gidilebilirMi = false;
                    sayac++;
                }
                if (gidilebilirMi == true && b.Parent != HedefP)
                {
                    listBox1.Items.Add(SuruklenenButton.Name + "  " + b.Parent.Name.ToString() + " -> " + HedefP.Name.ToString());
                    SuruklenenButton.Location = new Point(buttonKonumX, HedefP.Height - sayac * 30);
                    HedefP.Controls.Add(SuruklenenButton);
                    hamleSayisi++;
                    labelHamleSayisi.Text = "Hamle Sayisi : " + hamleSayisi.ToString();
                    int p3BSayisi = 0;
                    foreach (Button pButton in panel3.Controls)
                    {
                        p3BSayisi++;
                    }
                    if (HedefP == panel3 && p3BSayisi == buttonSayisi)
                    {
                        foreach (Button pButton in panel3.Controls)
                        {
                            if (buttonGenislik < pButton.Width)
                            {
                                oyunBitti = true;
                            }
                        }
                    }
                    if (oyunBitti == true && p3BSayisi == buttonSayisi)
                    {
                        timer_sure.Stop();
                        int dakika = saniye / 60;
                        MessageBox.Show(labelKullanıcı.Text + " " + hamleSayisi.ToString() + " Hamle de yaptın. " + "\nSüreniz : " + (saniye > 60 ? dakika + "  Dakika  " + (saniye - (dakika * 60)).ToString() + " Saniye" : saniye.ToString() + " Saniye"), "Tebrikler Oyunu Bitirdiniz.");
                        ad = Convert.ToString(labelKullanıcı.Text);
                        yas = Convert.ToInt16(labelYas.Text);
                        disksayi = Convert.ToInt16(cB1.Text);
                        hamle = hamleSayisi;
                        süre = saniye;
                        veriekle();
                        tablogoster();
                        panelTemizle();
                    }
                }
            }
        }
        private void panel_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelHamleSayisi.Text = "";
            labelSure.Text = "";
            labelKullanıcı.Text = "";
            labelYas.Text = "";
            this.Activate();
            this.Focus();
            cB1.SelectedIndex = 0;
            btnOyna.Enabled = false;
            button1.Enabled = false;
            tablogoster();

        }
        public void panelTemizle()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            listBox1.Items.Clear();
            labelKullanıcı.Text = "";
            labelYas.Text = "";
            labelHamleSayisi.Text = "";
            labelSure.Text = "";
            timer_sure.Stop();
        }
        public void yeniOyun()
        {
            panelTemizle();
            hamleSayisi = 0;
            labelHamleSayisi.Text = "Hamle Sayisi : " + hamleSayisi.ToString();
            labelKullanıcı.Text = textBox1.Text;
            labelYas.Text = textBox2.Text;
            buttonSayisi = Int32.Parse(cB1.SelectedItem.ToString());
            int bXkonum = ((panel1.Width - (buttonSayisi * 20)) / 2);
            for (int i = buttonSayisi; i > 0; i--)
            {
                Button butonlar = new Button();
                butonlar.Location = new Point(bXkonum, 390 - (((buttonSayisi + 1) - i) * 30));
                butonlar.Name = "Disk " + i.ToString();
                butonlar.Size = new Size(20 * i, 30);
                butonlar.BackColor = Color.FromArgb(rasgeleSayi.Next(255), rasgeleSayi.Next(255), rasgeleSayi.Next(255));
                butonlar.FlatStyle = FlatStyle.Flat;
                butonlar.Text = i.ToString();
                panel1.Controls.Add(butonlar);
                butonlar.Cursor = Cursors.SizeAll;
                butonlar.MouseDown += butonlar_MouseDown;
                bXkonum += 10;
            }
            saniye = 0;
            timer_sure.Start();
        }
        private void timer_sure_Tick(object sender, EventArgs e)
        {
            saniye++;
            labelSure.Text = " Süreniz(sn) :" + saniye.ToString();
        }
        private void btnOyna_Click(object sender, EventArgs e)
        {
            yeniOyun();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                btnOyna.Enabled = false;
            else if (textBox2.Text == "")
                btnOyna.Enabled = false;
            else
                btnOyna.Enabled = true;
        }
    }
}