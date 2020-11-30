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
using System.Collections;
namespace WindowsFormsApplication2
{
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}
		string[] koltuklar = new string[33];
		string[] idler = new string[33];
		OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=Kullanicilar.accdb");
		private void Koltuklarıcek()
		{
			baglantim.Open();
			OleDbCommand selectsorgu = new OleDbCommand("select* from Koltuklar ", baglantim);
			OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
			int i = 0;
			while (kayitokuma.Read())
			{
				idler[i] = kayitokuma.GetValue(0).ToString();
				koltuklar[i] = kayitokuma.GetValue(1).ToString();

				if (idler[i]=="1" && koltuklar[i]=="1")
				{

					button148.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i]=="1" && koltuklar[i]=="0")
				{
					button148.BackColor = Color.DodgerBlue;
					i++;
				}


				if (idler[i]=="2" && koltuklar[i]=="1")
				{
					button149.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i]=="2" && koltuklar[i]=="0")
				{
					button149.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "3" && koltuklar[i] == "1")
				{
					button150.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "3" && koltuklar[i] == "0")
				{
					button150.BackColor = Color.DodgerBlue;
					i++;
				}

				if (idler[i] == "4" && koltuklar[i] == "1")
				{
					button145.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "4" && koltuklar[i] == "0")
				{
					button145.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "5" && koltuklar[i] == "1")
				{
					button146.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "5" && koltuklar[i] == "0")
				{
					button146.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "6" && koltuklar[i] == "1")
				{
					button147.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "6" && koltuklar[i] == "0")
				{
					button147.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "7" && koltuklar[i] == "1")
				{
					button9.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "7" && koltuklar[i] == "0")
				{
					button9.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "8" && koltuklar[i] == "1")
				{
					button10.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "8" && koltuklar[i] == "0")
				{
					button10.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "9" && koltuklar[i] == "1")
				{
					button8.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "9" && koltuklar[i] == "0")
				{
					button8.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "10" && koltuklar[i] == "1")
				{
					button11.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "10" && koltuklar[i] == "0")
				{
					button11.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "11" && koltuklar[i] == "1")
				{
					button7.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "11" && koltuklar[i] == "0")
				{
					button7.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "12" && koltuklar[i] == "1")
				{
					button12.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "12" && koltuklar[i] == "0")
				{
					button12.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "13" && koltuklar[i] == "1")
				{
					button24.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "13" && koltuklar[i] == "0")
				{
					button24.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "14" && koltuklar[i] == "1")
				{
					button21.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "14" && koltuklar[i] == "0")
				{
					button21.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "15" && koltuklar[i] == "1")
				{
					button18.BackColor = Color.Gainsboro;
				}
				if (idler[i] == "15" && koltuklar[i] == "0")
				{
					button18.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "16" && koltuklar[i] == "1")
				{
					button15.BackColor = Color.Gainsboro;
					i++;
				}
			   if (idler[i] == "16" && koltuklar[i] == "0")
				{
					button15.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "17" && koltuklar[i] == "1")
				{
					button25.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "17" && koltuklar[i] == "0")
				{
					button25.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "18" && koltuklar[i] == "1")
				{
					button70.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "18" && koltuklar[i] == "0")
				{
					button70.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "19" && koltuklar[i] == "1")
				{
					button26.BackColor = Color.Gainsboro;
					i++;
				}
			  if (idler[i] == "19" && koltuklar[i] == "0")
				{
					button26.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "20" && koltuklar[i] == "1")
				{
					button71.BackColor = Color.Gainsboro;
					i++;
				}
			   if (idler[i] == "20" && koltuklar[i] == "0")
				{
					button71.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "21" && koltuklar[i] == "1")
				{
					button27.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "21" && koltuklar[i] == "0")
				{
					button27.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "22" && koltuklar[i] == "1")
				{
					button72.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "22" && koltuklar[i] == "0")
				{
					button72.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "23" && koltuklar[i] == "1")
				{
					button69.BackColor = Color.Gainsboro;
					i++;
				}
			   if (idler[i] == "23" && koltuklar[i] == "0")
				{
					button69.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "24" && koltuklar[i] == "1")
				{
					button66.BackColor = Color.Gainsboro;
					i++;
				}
			   if (idler[i] == "24" && koltuklar[i] == "0")
				{
					button66.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "25" && koltuklar[i] == "1")
				{
					button63.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "25" && koltuklar[i] == "0")
				{
					button63.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "26" && koltuklar[i] == "1")
				{
					button60.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "26" && koltuklar[i] == "0")
				{
					button60.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "27" && koltuklar[i] == "1")
				{
					button123.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "27" && koltuklar[i] == "0")
				{
					button123.BackColor = Color.DodgerBlue;
					i++;

				}
				if (idler[i] == "28" && koltuklar[i] == "1")
				{
					button120.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "28" && koltuklar[i] == "0")
				{
					button120.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "29" && koltuklar[i] == "1")
				{
					button119.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "29" && koltuklar[i] == "0")
				{
					button119.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "30" && koltuklar[i] == "1")
				{
					button122.BackColor = Color.Gainsboro;
					i++;
				}
			 if (idler[i] == "30" && koltuklar[i] == "0")
				{
					button122.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "31" && koltuklar[i] == "1")
				{
					button121.BackColor = Color.Gainsboro;
					i++;
				}
				if (idler[i] == "31" && koltuklar[i] == "0")
				{
					button121.BackColor = Color.DodgerBlue;
					i++;

				}

				if (idler[i] == "32" && koltuklar[i] == "1")
				{
					button118.BackColor = Color.Gainsboro;
					i++;
				}
				 if (idler[i] == "32" && koltuklar[i] == "0")
				{
					button118.BackColor = Color.DodgerBlue;
					i++;

				}

			  



			}
			baglantim.Close();
		   
		}

      public  string Koltukisim = "";
		private void Form6_Load(object sender, EventArgs e)
		{
			Koltuklarıcek();
			button148.Name = "1";
			button149.Name = "2";
			button150.Name = "3";
			button145.Name = "4";
			button146.Name = "5";
			button147.Name = "6";
			button9.Name = "7";
			button10.Name = "8";
			button8.Name = "9";
			button11.Name = "10";
			button7.Name = "11";
			button12.Name = "12";
			button24.Name = "13";
			button21.Name = "14";
			button18.Name = "15";
			button15.Name = "16";
			button25.Name = "17";
			button70.Name = "18";
			button26.Name = "19";
			button71.Name = "20";
			button27.Name = "21";
			button72.Name = "22";
			button69.Name = "23";
			button66.Name = "24";
			button63.Name = "25";
			button60.Name = "26";
			button123.Name = "27";
			button120.Name = "28";
			button119.Name = "29";
			button122.Name = "30";
			button121.Name = "31";
			button118.Name = "32";
			button115.Name = "33";

			KoltuklarıGüncelle();

		}
		string[] idler2 = new string[33];
		private void KoltuklarıGüncelle()
		{
		   
			 idler2[0]=button148.Name; idler2[1]=button149.Name; idler2[2]=button150.Name; idler2[3]=button145.Name; idler2[4]=button146.Name;
			idler2[5]=button147.Name; idler2[6]=button9.Name; idler2[7]=button10.Name; idler2[8]=button9.Name; idler2[9]=button11.Name;
			idler2[10]=button7.Name; idler2[11]=button12.Name; idler2[12]=button24.Name; idler2[13]=button21.Name; idler2[14]=button18.Name;
			idler2[15]=button15.Name; idler2[16]=button25.Name; idler2[17]=button70.Name; idler2[18]=button26.Name; idler2[19]=button71.Name;
			idler2[20]=button27.Name; idler2[21]=button72.Name; idler2[22]=button69.Name; idler2[23]=button66.Name; idler2[24]=button63.Name;
			idler2[25]=button60.Name; idler2[26]=button123.Name; idler2[27]=button120.Name; idler2[28]=button119.Name; idler2[29]=button122.Name;
			idler2[30]=button121.Name; idler2[31]=button118.Name; idler2[32]=button115.Name; 

			
		   

		}
	   
		private void button148_Click(object sender, EventArgs e)
		{
            Koltukisim = "24F";

			button148.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[0] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button149_Click(object sender, EventArgs e)
		{
            Koltukisim = "24E";
			button149.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='"+ 1+"'where id='" + idler2[1] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button150_Click(object sender, EventArgs e)
		{
            Koltukisim = "24D";
			button150.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[2] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button145_Click(object sender, EventArgs e)
		{
            Koltukisim = "25F";
			button145.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[3] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button146_Click(object sender, EventArgs e)
		{
            Koltukisim = "25E";
			button146.BackColor = Color.Red;

			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[4] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button147_Click(object sender, EventArgs e)
		{
            Koltukisim = "25D";
			button147.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[5] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();
		}
		private void button9_Click(object sender, EventArgs e)
		{
            Koltukisim = "3C";
			button9.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[6] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button10_Click(object sender, EventArgs e)
		{
            Koltukisim = "23B";
			button10.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[7] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button8_Click(object sender, EventArgs e)
		{
            Koltukisim = "3B";
			button8.BackColor = Color.Red;
			 baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[8] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button11_Click(object sender, EventArgs e)
        {
            Koltukisim = "4B";
			button11.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[9] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button7_Click(object sender, EventArgs e)
		{
            Koltukisim = "22B";
			button7.BackColor = Color.Red;


 baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[10] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button12_Click(object sender, EventArgs e)
		{
            Koltukisim = "4C";
			button12.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[11] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}
		private void button24_Click(object sender, EventArgs e)
		{
            Koltukisim = "8C";
			button24.BackColor = Color.Red;
		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[12] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button21_Click(object sender, EventArgs e)
		{
            Koltukisim = "7C";
			button21.BackColor = Color.Red;

		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[13] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button18_Click(object sender, EventArgs e)
		{
            Koltukisim = "6C";
			button18.BackColor = Color.Red;

		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[14] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button15_Click(object sender, EventArgs e)
		{
            Koltukisim = "5C";
			button15.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[15] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button25_Click(object sender, EventArgs e)
		{
            Koltukisim = "21A";
			button25.BackColor = Color.Red;
		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[16] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button70_Click(object sender, EventArgs e)
		{
            Koltukisim = "20B";
			button70.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[17] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button26_Click(object sender, EventArgs e)
		{
            Koltukisim = "9B";
			button26.BackColor = Color.Red;

			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[18] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button71_Click(object sender, EventArgs e)
		{
            Koltukisim = "2B";
			button71.BackColor = Color.Red;
			 baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[19] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();
			

		}


		private void button27_Click(object sender, EventArgs e)
		{
            Koltukisim = "9C";
			button27.BackColor = Color.Red;
			 baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[20] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button72_Click(object sender, EventArgs e)
		{
            Koltukisim = "17F";
			button72.BackColor = Color.Red;
		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[21] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button69_Click(object sender, EventArgs e)
		{
            Koltukisim = "17E";
			button69.BackColor = Color.Red;
		  baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[22] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button66_Click(object sender, EventArgs e)
		{
            Koltukisim = "26F";

			button66.BackColor = Color.Red;
			 baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[23] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button63_Click(object sender, EventArgs e)
		{
            Koltukisim = "26E";

			button63.BackColor = Color.Red;
		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[24] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button60_Click(object sender, EventArgs e)
		{
            Koltukisim = "26D";
			button60.BackColor = Color.Red;
		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[25] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button123_Click(object sender, EventArgs e)
		{
            Koltukisim = "12D";
			button123.BackColor = Color.Red;
		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[26] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}
		private void button120_Click(object sender, EventArgs e)
		{
            Koltukisim = "13D";
			button120.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[27] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button119_Click(object sender, EventArgs e)
		{
            Koltukisim = "13E";
			button119.BackColor = Color.Red;
			baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[28] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();
 

		}

		private void button122_Click(object sender, EventArgs e)
		{
            Koltukisim = "12E";
			button122.BackColor = Color.Red;
			 baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[29] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button121_Click(object sender, EventArgs e)
		{
            Koltukisim = "12F";
			button121.BackColor = Color.Red;
			 baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[30] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();

		}

		private void button118_Click(object sender, EventArgs e)
		{
            Koltukisim = "13F";
			button118.BackColor = Color.Red;
		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[31] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}

		private void button115_Click(object sender, EventArgs e)
		{
            Koltukisim = "14F";
			button115.BackColor = Color.Red;
		   baglantim.Open();
			OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar set koltukdurumu='" + 1 + "'where id='" + idler2[32] + "'", baglantim);
			güncellekomutu.ExecuteNonQuery();
			baglantim.Close();


		}




		private void button154_Click(object sender, EventArgs e)
		{
			baglantim.Open();
			OleDbCommand selectsorgu = new OleDbCommand("select* from Koltuklar ", baglantim);
			OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
			int i=0;
			while (kayitokuma.Read())

			{
				 idler[i] = kayitokuma.GetValue(0).ToString();
				koltuklar[i] = kayitokuma.GetValue(1).ToString();

				if (idler[i] == "1" && koltuklar[i] == "1")
				{

					button148.BackColor = Color.Gainsboro;
					button148.Enabled = false;
					i++;
				}
				if (idler[i] == "2" && koltuklar[i] == "1")
				{
					button149.BackColor = Color.Gainsboro;
					button149.Enabled = false;
					i++;
				}
				if (idler[i] == "3" && koltuklar[i] == "1")
				{
					button150.BackColor = Color.Gainsboro;
					button150.Enabled = false;
					i++;
				}
				if (idler[i] == "4" && koltuklar[i] == "1")
				{
					button145.BackColor = Color.DodgerBlue;
					button145.Enabled = false;
					i++;

				}
				if (idler[i] == "5" && koltuklar[i] == "1")
				{
					button146.BackColor = Color.Gainsboro;
					button146.Enabled = false;
					i++;
				}

				if (idler[i] == "6" && koltuklar[i] == "1")
				{
					button147.BackColor = Color.Gainsboro;
					button147.Enabled = false;
					i++;
				}

				if (idler[i] == "7" && koltuklar[i] == "1")
				{
					button9.BackColor = Color.Gainsboro;
					button9.Enabled = false;
					i++;
				}
				if (idler[i] == "8" && koltuklar[i] == "1")
				{
					button10.BackColor = Color.Gainsboro;
					button10.Enabled = false;
					i++;
				}
				if (idler[i] == "9" && koltuklar[i] == "1")
				{
					button8.BackColor = Color.Gainsboro;
					button8.Enabled = false;
					i++;
				}
				if (idler[i] == "10" && koltuklar[i] == "1")
				{
					button11.BackColor = Color.Gainsboro;
					button11.Enabled = false;
					i++;
				}
				if (idler[i] == "11" && koltuklar[i] == "1")
				{
					button7.BackColor = Color.Gainsboro;
					button7.Enabled = false;
					i++;
				}
				if (idler[i] == "12" && koltuklar[i] == "1")
				{
					button12.BackColor = Color.Gainsboro;
					button12.Enabled = false;
					i++;
				}
				if (idler[i] == "13" && koltuklar[i] == "1")
				{
					button24.BackColor = Color.Gainsboro;
					button24.Enabled = false;
					i++;
				}

				if (idler[i] == "14" && koltuklar[i] == "1")
				{
					button21.BackColor = Color.Gainsboro;
					button21.Enabled = false;
					i++;
				}

				if (idler[i] == "15" && koltuklar[i] == "1")
				{
					button18.BackColor = Color.Gainsboro;
					button18.Enabled = false;
				}
				if (idler[i] == "16" && koltuklar[i] == "1")
				{
					button15.BackColor = Color.Gainsboro;
					button15.Enabled = false;
					i++;
				}
				if (idler[i] == "17" && koltuklar[i] == "1")
				{
					button25.BackColor = Color.Gainsboro;
					button25.Enabled = false;

					i++;
				}
				if (idler[i] == "18" && koltuklar[i] == "1")
				{
					button70.BackColor = Color.Gainsboro;
					button70.Enabled = false;
					i++;
				}
				if (idler[i] == "19" && koltuklar[i] == "1")
				{
					button26.BackColor = Color.Gainsboro;
					button26.Enabled = false;
					i++;
				}
				if (idler[i] == "20" && koltuklar[i] == "1")
				{
					button71.BackColor = Color.Gainsboro;
					button71.Enabled = false;
					i++;
				}
				if (idler[i] == "21" && koltuklar[i] == "1")
				{
					button27.BackColor = Color.Gainsboro;
					button27.Enabled = false;
					i++;
				}
				if (idler[i] == "22" && koltuklar[i] == "1")
				{
					button72.BackColor = Color.Gainsboro;
					button72.Enabled = false;
					i++;
				}
				if (idler[i] == "23" && koltuklar[i] == "1")
				{
					button69.BackColor = Color.Gainsboro;
					button69.Enabled = false;
					i++;
				}
				if (idler[i] == "24" && koltuklar[i] == "1")
				{
					button66.BackColor = Color.Gainsboro;
					button66.Enabled = false;
					i++;
				}
				if (idler[i] == "25" && koltuklar[i] == "1")
				{
					button63.BackColor = Color.Gainsboro;
					button63.Enabled = false;
					i++;
				}
				if (idler[i] == "26" && koltuklar[i] == "1")
				{
					button60.BackColor = Color.Gainsboro;
					button60.Enabled = false;
					i++;
				}
				if (idler[i] == "27" && koltuklar[i] == "1")
				{
					button123.BackColor = Color.Gainsboro;
					button123.Enabled = false;
					i++;
				}
				if (idler[i] == "28" && koltuklar[i] == "1")
				{
					button120.BackColor = Color.Gainsboro;
					button120.Enabled = false;
					i++;
				}
				if (idler[i] == "29" && koltuklar[i] == "1")
				{
					button119.BackColor = Color.Gainsboro;
					button119.Enabled = false;
					i++;
				}
				if (idler[i] == "30" && koltuklar[i] == "1")
				{
					button122.BackColor = Color.Gainsboro;
					button122.Enabled = false;
					i++;
				}
				if (idler[i] == "31" && koltuklar[i] == "1")
				{
					button121.BackColor = Color.Gainsboro;
					button121.Enabled = false;
					i++;
				}
				if (idler[i] == "32" && koltuklar[i] == "1")
				{
					button118.BackColor = Color.Gainsboro;
					button118.Enabled = false;
					i++;
				}
				if (idler[i] == "33" && koltuklar[i] == "1")
				{
					button115.BackColor = Color.Gainsboro;
					button115.Enabled = false;
					i++;
				}

				
			}
			MessageBox.Show("Biletme İşlemi Başarılı İyi Uçuşlar Dileriz...","Uçak Bileti Satış Otomasyonu", MessageBoxButtons.OK,MessageBoxIcon.Information);
			baglantim.Close();

		}

		private void button155_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
            frm2.textBox1.Text = Koltukisim;
			this.Hide();
			frm2.Show();
		}


	}
}
