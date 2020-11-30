using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=Kullanicilar.accdb");

        private void kullanicilari_göster()
        {
            try
            {

                baglantim.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select tcno AS[TC KİMLİK NO],ad AS[ADI],soyad AS [SOYADI],kullaniciadi AS[KULLANICI ADI],parola AS[PAROLA],yetki AS[YETKİ],eposta AS[EPOSTA],kartbilgileri AS [KART BİLGİLERİ],cvv AS[CVV] from Kullanicilar Order by ad ASC", baglantim);
                DataSet dshafiza = new DataSet();
                kullanicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglantim.Close();


            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message, "Uçak Bileti Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close();
            }


        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "YÖNETİCİ İŞLEMLERİ";
           
            textBox1.MaxLength = 11;
            textBox4.MaxLength = 20;
            toolTip1.SetToolTip(this.textBox1, "tc kimlik no 11 haneli olmalı!");
            radioButton1.Checked = true;
            textBox5.MaxLength = 15;
            textBox6.MaxLength = 15;
            textBox9.MaxLength = 3;
            textBox8.MaxLength = 16;
            kullanicilari_göster();
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 11)
            {
                errorProvider1.SetError(textBox1, "tc kimlik no 11 karakter olmalı ");


            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)

                e.Handled = false;
            else
                e.Handled = true;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)

                e.Handled = false;
            else
                e.Handled = true;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length <5)
            {
                errorProvider1.SetError(textBox4, "geçerli bir kullanıcı adı giriniz. ");


            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)

                e.Handled = false;
            else
                e.Handled = true;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string sifre = textBox5.Text;
            if (sifre.Contains("I") == true || sifre.Contains("ı") == true ||
                sifre.Contains("Ç") == true || sifre.Contains("ç") == true ||
                sifre.Contains("ğ") == true || sifre.Contains("Ğ") == true ||
                sifre.Contains("Ş") == true || sifre.Contains("ş") == true ||
                sifre.Contains("Ö") == true || sifre.Contains("ö") == true ||
                sifre.Contains("Ü") == true || sifre.Contains("ü") == true)
            {

                MessageBox.Show("türkçe karakter kullanmayınız.");

            }
            int BüyükHarfsayisi = sifre.Length - Regex.Replace(sifre, "[A-Z]", "").Length;
            int Rakamsayisi = sifre.Length - Regex.Replace(sifre, "[0-9]", "").Length;

            if (BüyükHarfsayisi == 0 || Rakamsayisi == 0)
            {
                label8.Text = "Şifrenizde en az 1 adet rakam ve büyük harf bulunmalıdır.";

            }
            else
            {
                label8.Text = "";
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
      


        private void toppage1_temizle()
        {

            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
            textBox7.Clear(); textBox8.Clear(); textBox9.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yetki = "";
            bool kayitkontrol = false;
            baglantim.Open();
            OleDbCommand selectsorgu = new OleDbCommand("select* from Kullanicilar where tcno='" + textBox1.Text + "'", baglantim);
            OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitkontrol = true;
                break;

            }
            baglantim.Close();

            if (kayitkontrol == false)
            {
                if (textBox1.Text.Length < 11 || textBox1.Text == "")
                    label1.ForeColor = Color.DarkRed;
                else
                    label1.ForeColor = Color.Black;
                if (textBox2.Text.Length < 2 || textBox2.Text == "")
                    label2.ForeColor = Color.DarkRed;
                else
                    label2.ForeColor = Color.Black;
                if (textBox3.Text.Length < 2 || textBox3.Text == "")
                    label3.ForeColor = Color.DarkRed;
                else
                    label3.ForeColor = Color.Black;
                if (textBox4.Text.Length < 5 || textBox4.Text == "")
                    label5.ForeColor = Color.DarkRed;
                if (textBox5.Text == "" || textBox5.Text.Length < 5)
                    label6.ForeColor = Color.DarkRed;
                else
                    label6.ForeColor = Color.Black;
                if (textBox6.Text == "" || textBox6.Text != textBox5.Text)
                    label7.ForeColor = Color.DarkRed;
                else
                    label7.ForeColor = Color.Black;
                if (textBox7.Text == "" || textBox7.Text.Length < 10)//eposta
                    label9.ForeColor = Color.DarkRed;
                else
                    label9.ForeColor = Color.Black;
                if (textBox8.Text == "" || textBox8.Text.Length != 16)//kartbilgileri
                    label10.ForeColor = Color.DarkRed;
                else
                    label10.ForeColor = Color.Black;
                if (textBox9.Text == "" || textBox9.Text.Length != 3)//cvv
                    label11.ForeColor = Color.DarkRed;
                else
                    label11.ForeColor = Color.Black;
                if (textBox1.Text.Length == 11 && textBox1.Text != "" && textBox2.Text != "" && textBox2.Text.Length > 1 && textBox3.Text != "" && textBox3.Text.Length > 1 && textBox4.Text != ""&&textBox4.Text.Length>4 && textBox5.Text != "" && textBox6.Text != "" && textBox5.Text == textBox6.Text&&textBox7.Text!=""&&textBox7.Text.Length>10&&textBox8.Text!=""&&textBox8.Text.Length==16&&textBox9.Text!=""&&textBox9.Text.Length==3)

                {

                    if (radioButton1.Checked == true)
                        yetki = "Yönetici";
                    else if (radioButton2.Checked == true)
                        yetki = "Kullanıcı";

                    try
                    {
                        baglantim.Open();
                        OleDbCommand eklekomutu = new OleDbCommand("insert into Kullanicilar values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + yetki + "','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"')", baglantim);
                        eklekomutu.ExecuteNonQuery();
                        baglantim.Close();
                        MessageBox.Show("yeni kullanıcı kaydı oluşturuldu!", "Otomasyon İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        toppage1_temizle();

                    }
                    catch (Exception hatam)
                    {

                        MessageBox.Show(hatam.Message);
                        baglantim.Close();
                    }

                }

                else
                {
                    MessageBox.Show("bilgileri eksiksiz doldurunuz ", "Otomasyon işlem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("girilen tc kimlik numarası daha önceden kayıtlıdır ", "Otomasyon işlem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool kayit_arama_durumu = false;
            if (textBox1.Text.Length == 11)
            {
                baglantim.Open();
                OleDbCommand selectsorgu = new OleDbCommand("select* from Kullanicilar where tcno='" + textBox1.Text + "'", baglantim);
                OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    kayit_arama_durumu = true;
                    textBox2.Text = kayitokuma.GetValue(1).ToString();
                    textBox3.Text = kayitokuma.GetValue(2).ToString();
                    if (kayitokuma.GetValue(5).ToString() == "Yönetici")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                    textBox4.Text = kayitokuma.GetValue(3).ToString();
                    textBox5.Text = kayitokuma.GetValue(4).ToString();
                    textBox6.Text = kayitokuma.GetValue(4).ToString();
                    textBox7.Text = kayitokuma.GetValue(6).ToString();
                    textBox8.Text = kayitokuma.GetValue(7).ToString();
                    textBox9.Text = kayitokuma.GetValue(8).ToString();
                    break;

                }
                if (kayit_arama_durumu == false)
                {
                    MessageBox.Show("Aranan kayit bulunamadi", "Otomasyon Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    baglantim.Close();

                }
            }
            else
            {
                MessageBox.Show("lütfen 11 haneli bir tc kimlik numarası giriniz. ", "Otomasyon Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toppage1_temizle();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string yetki = "";

                if (textBox1.Text.Length < 11 || textBox1.Text == "")
                    label1.ForeColor = Color.DarkRed;
                else
                    label1.ForeColor = Color.Black;
            if (textBox2.Text.Length < 2 || textBox2.Text == "")
                label2.ForeColor = Color.DarkRed;
            else
                label2.ForeColor = Color.Black;
            if (textBox3.Text.Length < 2 || textBox3.Text == "")
                label3.ForeColor = Color.DarkRed;
            else
                label3.ForeColor = Color.Black;
            if (textBox4.Text.Length < 5 || textBox4.Text == "")
                label5.ForeColor = Color.DarkRed;
            if (textBox5.Text == "" || textBox5.Text.Length < 5)
                label6.ForeColor = Color.DarkRed;
            else
                label6.ForeColor = Color.Black;
            if (textBox6.Text == "" || textBox6.Text != textBox5.Text)
                label7.ForeColor = Color.DarkRed;
            else
                label7.ForeColor = Color.Black;
            if (textBox7.Text == "" || textBox7.Text.Length < 10) //eposta
                label9.ForeColor = Color.DarkRed;
            else
                label9.ForeColor = Color.Black;
            if (textBox8.Text == "" || textBox8.Text.Length != 16)//kartbilgileri
                label10.ForeColor = Color.DarkRed;
            else
                label10.ForeColor = Color.Black;
            if (textBox9.Text == "" || textBox9.Text.Length != 3)//cvv
                label11.ForeColor = Color.DarkRed;
            else
                label11.ForeColor = Color.Black;
            if (textBox1.Text.Length == 11 && textBox1.Text != "" && textBox2.Text != "" && textBox2.Text.Length > 1 && textBox3.Text != "" && textBox3.Text.Length > 1 && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox5.Text == textBox6.Text && textBox7.Text != "" && textBox8.Text != "" && textBox8.Text.Length == 16 && textBox9.Text != "" && textBox9.Text.Length == 3)
            {

                if (radioButton1.Checked == true)
                    yetki = "Yönetici";
                else if (radioButton2.Checked == true)
                    yetki = "Kullanıcı";

                try
                {
                    baglantim.Open();
                    OleDbCommand guncellekomutu = new OleDbCommand("update  Kullanicilar set ad='" + textBox2.Text + "',soyad='" + textBox3.Text + "',kullaniciadi='" + textBox4.Text + "',parola='" + textBox5.Text + "',yetki='" +yetki+"',eposta='"+textBox7.Text+"',kartbilgileri='"+textBox8.Text+"',cvv='"+textBox9.Text+ "'where tcno='" + textBox1.Text + "'", baglantim);
                    
                    guncellekomutu.ExecuteNonQuery();
                    baglantim.Close();
                    MessageBox.Show("yeni kullanıcı kaydı oluşturuldu!", "Uçak Bileti Satış Otomasyonu ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kullanicilari_göster();

                }
                catch (Exception hatam)
                {

                    MessageBox.Show(hatam.Message, "Uçak Bileti Satış Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglantim.Close();
                }

            }

            else
            {
                MessageBox.Show("bilgileri eksiksiz doldurunuz ", "Uçak Bileti Satış Otomasyonu ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 11)
            {
                bool kayit_arama_durumu = false;
                baglantim.Open();
                OleDbCommand selectsorgu = new OleDbCommand("select* from Kullanicilar where tcno='" + textBox1.Text + "'", baglantim);
                OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    kayit_arama_durumu = true;
                    OleDbCommand deletesorgu = new OleDbCommand("delete from Kullanicilar where tcno='" + textBox1.Text + "'", baglantim);
                    deletesorgu.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı kaydı silindi ", "Uçak Bileti Satış Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglantim.Close();
                    kullanicilari_göster();
                    toppage1_temizle();
                    break;

                }
                if (kayit_arama_durumu == false)

                    MessageBox.Show("silinecek kayıt bulunamadı ", "Uçak Bileti Satış Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close();
                toppage1_temizle();


            }
            else
                MessageBox.Show("lütfen 11karakterden oluşan bir tc kimlik no giriniz.", "Uçak Bileti Satış Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toppage1_temizle();

        }

      
       

       


    }
}
