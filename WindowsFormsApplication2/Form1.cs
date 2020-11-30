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
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0; Data Source=Kullanicilar.accdb");

        public static string tcno, adi, soyadi, yetki,eposta,kartbilgileri,cvv,kullaniciadi;
        bool durum = false; int hak=3;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox10.MaxLength = 11;
            textBox8.MaxLength = 16;
            textBox9.MaxLength = 9;
            this.Text = "Kullanıcı Girişi";
            this.AcceptButton = button1;
            radioButton1.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           if (hak != 0)
            {
                baglantim.Open();
                OleDbCommand selectsorgu = new OleDbCommand("select * from kullanicilar", baglantim);
                OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    if (radioButton1.Checked == true)
                    {
                        if (kayitokuma["kullaniciadi"].ToString() == textBox2.Text && kayitokuma["parola"].ToString() == textBox3.Text && kayitokuma["yetki"].ToString() == "Yönetici")
                        {
                            durum = true;
                            tcno = kayitokuma.GetValue(0).ToString();
                            adi = kayitokuma.GetValue(1).ToString();
                            soyadi = kayitokuma.GetValue(2).ToString();
                            kullaniciadi = kayitokuma.GetValue(3).ToString();
                            yetki = kayitokuma.GetValue(5).ToString();
                            eposta = kayitokuma.GetValue(6).ToString();
                            kartbilgileri = kayitokuma.GetValue(7).ToString();
                            cvv = kayitokuma.GetValue(8).ToString();
                            this.Hide();
                            Form3 frm3 = new Form3();
                            frm3.Show();
                            break;

                        }
                       
                        
                        
                    }

                    if (radioButton2.Checked == true)
                    {
                        if (kayitokuma["kullaniciadi"].ToString() == textBox2.Text && kayitokuma["parola"].ToString() == textBox3.Text && kayitokuma["yetki"].ToString() == "Kullanıcı")
                        {
                            durum = true;
                            tcno = kayitokuma.GetValue(0).ToString();
                            adi = kayitokuma.GetValue(1).ToString();
                            soyadi = kayitokuma.GetValue(2).ToString();
                            kullaniciadi = kayitokuma.GetValue(3).ToString();
                            yetki = kayitokuma.GetValue(5).ToString();
                            eposta = kayitokuma.GetValue(6).ToString();
                            kartbilgileri = kayitokuma.GetValue(7).ToString();
                            cvv = kayitokuma.GetValue(8).ToString();
                            this.Hide();
                            Form2 frm2 = new Form2();
                            frm2.Show();
                            break;
                        }
                        
                        
                    }
                    
                        
                }

                if (durum == false)
                    
                        MessageBox.Show("hatalı kullanıcı adı veya şifre", "Otomasyon Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hak--;
                baglantim.Close();
            }
            
            if (hak == 0)
            {
                button1.Enabled = false;
                MessageBox.Show("Giriş hakkı kalmadı!", "Otomasyon Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            textBox10.Clear(); textBox4.Clear(); textBox11.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox1.Clear();
            textBox8.Clear(); textBox9.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            string yetki = "";
            bool kayitkontrol = false;
            baglantim.Open();
            OleDbCommand selectsorgu = new OleDbCommand("select* from Kullanicilar where tcno='" + textBox10.Text + "'", baglantim);
            OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitkontrol = true;
                break;

            }
            baglantim.Close();

            if (kayitkontrol == false)
            {

                if (textBox10.Text.Length < 11 || textBox10.Text == "")//tc
                    label11.ForeColor = Color.DarkRed;
                else
                    label11.ForeColor = Color.Black;

                if (textBox4.Text.Length < 2 || textBox4.Text == "")//ad
                    label3.ForeColor = Color.DarkRed;
                else
                    label3.ForeColor = Color.Black;

                if (textBox11.Text.Length < 2 || textBox11.Text == "")//soyad
                    label12.ForeColor = Color.DarkRed;
                else
                    label12.ForeColor = Color.Black;

                if (textBox5.Text.Length < 2 || textBox5.Text == "")//k.adi
                    label4.ForeColor = Color.DarkRed;
                else
                    label4.ForeColor = Color.Black;

                if (textBox6.Text.Length < 5 || textBox6.Text == "")
                    label6.ForeColor = Color.DarkRed;
                else
                    label6.ForeColor = Color.Black;
                if (textBox7.Text == "" || textBox6.Text != textBox7.Text)
                    label9.ForeColor = Color.DarkRed;
                else
                    label9.ForeColor = Color.Black;

                if (textBox8.Text == "" || textBox8.Text.Length != 16)//kartbilgileri
                    label7.ForeColor = Color.DarkRed;
                else
                    label7.ForeColor = Color.Black;

                if (textBox9.Text == "" || textBox9.Text.Length != 3)//cvv
                    label8.ForeColor = Color.DarkRed;
                else
                    label8.ForeColor = Color.Black;

                if (textBox10.Text.Length == 11 && textBox10.Text != "" && textBox4.Text.Length > 2 && textBox4.Text != "" && textBox11.Text.Length > 2 && textBox11.Text != "" && textBox5.Text.Length > 2 && textBox5.Text != "" && textBox6.Text.Length > 5 && textBox6.Text != "" && textBox7.Text != "" && textBox6.Text == textBox7.Text && textBox8.Text != "" && textBox8.Text.Length == 16 && textBox9.Text.Length == 3 && textBox9.Text != "")
                {
                    yetki = "Kullanıcı";

                    try
                    {
                        baglantim.Open();
                        OleDbCommand eklekomutu = new OleDbCommand("insert into Kullanicilar values ('" + textBox10.Text + "','" + textBox4.Text + "','" + textBox11.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + yetki + "','" + textBox1.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", baglantim);
                        eklekomutu.ExecuteNonQuery();
                        baglantim.Close();
                        MessageBox.Show("yeni kullanıcı kaydı oluşturuldu!", "Otomasyon İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yetki = "misafir";
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();

        }

                
            }

        }