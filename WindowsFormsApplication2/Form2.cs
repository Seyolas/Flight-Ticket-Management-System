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
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApplication2
	
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=Kullanicilar.accdb");
		public static string tarih1,tarih2;
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		 
		}
		private void topPage2temizle(){

			textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); textBox9.Clear();
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			 textBox3.MaxLength = 11;
			  toolTip1.SetToolTip(this.textBox3, "tc kimlik no 11 haneli olmalı!");
			textBox9.MaxLength = 3;
			textBox8.MaxLength = 16;
			textBox3.Text = Form1.tcno;
			textBox4.Text = Form1.kullaniciadi;
			textBox7.Text = Form1.eposta;
			textBox8.Text = Form1.kartbilgileri;
			textBox9.Text = Form1.cvv;
         
			
		}
	   
		private void button2_Click(object sender, EventArgs e)
		{
			 
			bool kayitkontrol = false;
			baglantim.Open();
			OleDbCommand selectsorgu = new OleDbCommand("select* from Kullanicilar where tcno='" + textBox3.Text + "'", baglantim);
			OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
			while (kayitokuma.Read())
			{
				kayitkontrol = true;
				break;

			}
			baglantim.Close();
			if (kayitkontrol == false)
			

				if (textBox3.Text.Length < 11 || textBox3.Text == "")//tc no
					label18.ForeColor = Color.Red;
				else
					label18.ForeColor = Color.Black;

				if (textBox4.Text.Length < 2 || textBox4.Text == "")//kullanıcı adı
					label6.ForeColor = Color.Red;
				else
					label6.ForeColor = Color.Black;

				if (textBox5.Text.Length < 8 || textBox5.Text == "")//parola
					label7.ForeColor = Color.DarkRed;
				else
					label7.ForeColor = Color.Black;

				if (textBox6.Text == "" || textBox6.Text != textBox5.Text)//parolatekrar
					label8.ForeColor = Color.DarkRed;
				else
					label8.ForeColor = Color.Black;

				if (textBox7.Text == "" || textBox7.Text.Length < 10)//eposta
					label9.ForeColor = Color.Red;
				else
					label9.ForeColor = Color.Black;
				if (textBox8.Text == "" || textBox8.Text.Length != 16)
					label10.ForeColor = Color.Red;
				else
					label10.ForeColor = Color.Black;
				if (textBox9.Text.Length != 3)
					label11.ForeColor = Color.Red;
				if (textBox3.Text.Length == 11 && textBox4.Text != "" && textBox4.Text.Length > 2 && textBox5.Text != "" && textBox5.Text.Length >= 8 && textBox6.Text == textBox5.Text && textBox6.Text != "" && textBox7.Text != "" && textBox7.Text.Length > 10 && textBox8.Text != "" && textBox8.Text.Length == 16 && textBox9.Text != "" && textBox9.Text.Length == 3)
				{


					try
					{
						baglantim.Open();
						OleDbCommand guncellekomutu = new OleDbCommand("update Kullanicilar set kullaniciadi='" + textBox4.Text + "',parola='" + textBox5.Text + "',eposta='" + textBox7.Text + "',kartbilgileri='" + textBox8.Text + "',cvv='" + textBox9.Text + "'where tcno='" + textBox3.Text + "'", baglantim);
						guncellekomutu.ExecuteNonQuery();
						baglantim.Close();
						MessageBox.Show("Bilgieriniz Güncellendi!", "Uçak Bileti Satış Otomasyonu ", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

		private void button3_Click(object sender, EventArgs e)
		{
			
				bool kayit_arama_durumu = false;
				baglantim.Open();
				OleDbCommand selectsorgu = new OleDbCommand("select* from Kullanicilar where tcno='" + textBox3.Text + "'", baglantim);
				OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
				while (kayitokuma.Read())
				{
					kayit_arama_durumu = true;
					OleDbCommand deletesorgu = new OleDbCommand("delete from Kullanicilar where tcno='" + textBox3.Text + "'", baglantim);
					deletesorgu.ExecuteNonQuery();
					MessageBox.Show("Kullanıcı kaydı silindi ", "Uçak Bileti Satış Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
					baglantim.Close();
					topPage2temizle();
					break;

				}
				if (kayit_arama_durumu == false)

					MessageBox.Show("silinecek kayıt bulunamadı ", "Uçak Bileti Satış Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				baglantim.Close();
				topPage2temizle();


			

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{
			 
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			tarih1 = monthCalendar1.SelectionStart.ToString("d");
		   
		}

		private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
		{
			tarih2 = monthCalendar2.SelectionStart.ToString("d");

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text=="" || comboBox2.Text=="")
			{
                MessageBox.Show("Lütfen Kalkış Ve Varış Yeri Seçiniz.","Uçak Bileti Otomasyon Sistemi",MessageBoxButtons.OK,MessageBoxIcon.Error);
				
			  

			}
            else if (tarih1=="8/26/2020" && comboBox1.Text!="" && comboBox2.Text!="")
            {
               this.Hide();
				Form4 frm4 = new Form4();
				frm4.Show();
            }


            else
            
                MessageBox.Show("Belirtilen Tarihlere Ait Uçuş Bulunamadı. ", "Uçak Bileti Otomasyon Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Istanbul Havalimanı (IST), İstanbul,Türkiye" || comboBox1.Text== "Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");
				comboBox2.Items.Add("Antalya Havalimanı(AYT), Antalya,Türkiye");
				comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
				comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
				comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");
				comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");
				comboBox2.Items.Add("Dalaman Havalimanı(DLM), Muğla-Dalaman");
				comboBox2.Items.Add("Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum");
				comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");

			}

			else if (comboBox1.Text=="Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Antalya Havalimanı(AYT), Antalya,Türkiye");
				comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
				comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
				comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");
				comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");
				comboBox2.Items.Add("Dalaman Havalimanı(DLM), Muğla-Dalaman");
				comboBox2.Items.Add("Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum");
				comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");
				comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				
			}
			else if (comboBox1.Text=="Antalya Havalimanı(AYT), Antalya,Türkiye")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
				comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
				comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");
				comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");
				comboBox2.Items.Add("Dalaman Havalimanı(DLM), Muğla-Dalaman");
				comboBox2.Items.Add("Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum");
				comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");
				comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");

			}
			else if (comboBox1.Text=="Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
				comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");
				comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");
				comboBox2.Items.Add("Dalaman Havalimanı(DLM), Muğla-Dalaman");
				comboBox2.Items.Add("Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum");
				comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");
				comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");


			}
			else if (comboBox1.Text=="Elazığ Havalimanı (EZS), Elazığ,Türkiye")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");
				comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");
				comboBox2.Items.Add("Dalaman Havalimanı(DLM), Muğla-Dalaman");
				comboBox2.Items.Add("Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum");
				comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");
				comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");
				 comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
			}
			else if (comboBox1.Text=="Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");
				comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");
				comboBox2.Items.Add("Dalaman Havalimanı(DLM), Muğla-Dalaman");
				comboBox2.Items.Add("Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum");
				comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");
				comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");
				comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
				comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
			}
			else if (comboBox1.Text=="Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya")
			{
				comboBox2.Items.Clear();
				 comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				 comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");
				 comboBox2.Items.Add("Dalaman Havalimanı(DLM), Muğla-Dalaman");
				 comboBox2.Items.Add("Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum");
				 comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");
				 comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				 comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				 comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");
				 comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
				 comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
			}
			else if (comboBox1.Text=="Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Dalaman Havalimanı(DLM), Muğla-Dalaman");
				comboBox2.Items.Add("Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum");
				comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");
				comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");
				comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
				comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
				comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");

			}

			else if (comboBox1.Text=="Dalaman Havalimanı(DLM), Muğla-Dalaman")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");
				comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");
				comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
				comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
				comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");
				comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");


			}
			else if (comboBox1.Text=="Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum")
			 {
				 comboBox2.Items.Clear();
				 comboBox2.Items.Add("Trabzon Havalimanı(TZX), Trabzon, Türkiye");
				 comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				 comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				 comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");
				 comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
				 comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
				 comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				 comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");
				 comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");

			}
			else if (comboBox1.Text=="Trabzon Havalimanı(TZX), Trabzon, Türkiye")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Istanbul Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Istanbul Sabiha Gökçen Havalimanı (IST), İstanbul,Türkiye");
				comboBox2.Items.Add("Ankara Esenboğa Havalimanı(ESB), Ankara,Türkiye");
				comboBox2.Items.Add("Izmır Adnan Menderes Havalimanı (ADB), İzmir,Türkiye");
				comboBox2.Items.Add("Elazığ Havalimanı (EZS), Elazığ,Türkiye");
				comboBox2.Items.Add("Lefkoşa Ercan Uluslararası Havalimanı (ECN),Lefkoşa, Kuzey Kıbrıs Türk Cumhuriyeti");
				comboBox2.Items.Add("Bologna Guglielmo Marconi Havalimanı(BLQ), İtalya");
				comboBox2.Items.Add("Haydar Aliyev Uluslararası Havalimanı (GYD), Bakü");
				comboBox2.Items.Add("Milas-Bodrum Havalimanı(BJV), Muğla-Bodrum");
				comboBox2.Items.Add("Dalaman Havalimanı(DLM), Muğla-Dalaman");
			

			}
		}

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text=="Almanya")
            {
                label14.Text = "49 69 86 799 849";
            }
            if (comboBox3.Text=="Amerika Birleşik Devletleri")
            {
                label14.Text = "1-800-874 8875";
            }
            if (comboBox3.Text=="Arjantin")
            {
                label14.Text = "54(011) 5984 2758";

            }
            if (comboBox3.Text=="Azerbaycan")
            {
                label14.Text = "+90 212 444 0 849";
                
            }
            if (comboBox3.Text=="Brezilya")
            {
                label14.Text="55 11 3878 8199";

            }
            if (comboBox3.Text=="Polonya"){

                label14.Text = "4822 504 85 44";
            }
            if (comboBox3.Text == "Rusya") 
            {
                label14.Text = "8 0 800 700 61 61";

            }
            if (comboBox3.Text=="Türkiye")
            {
                label14.Text = "444 0 849";
            }
            if (comboBox3.Text=="Yunanistan")
            {
                label14.Text = "302119902313";
            }
	
		 
	
        }
	  
	   
	}
}
