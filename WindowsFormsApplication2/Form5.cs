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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string[] koltuklar = new string[43];
        string[] idler = new string[43];
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=Kullanicilar.accdb");

        private void KoltuklarıCek()
        {

            baglantim.Open();
            OleDbCommand selectsorgu = new OleDbCommand("select* from Koltuklar2 ", baglantim);
            OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
            int i = 0;
            while (kayitokuma.Read())
            {
                idler[i] = kayitokuma.GetValue(0).ToString();
                koltuklar[i] = kayitokuma.GetValue(1).ToString();
                if (idler[i] == "1" && koltuklar[i] == "1")
                {
                    button15.BackColor = Color.Gainsboro;
                    i++;

                }
                if (idler[i] == "1" && koltuklar[i] == "0")
                {
                    button15.BackColor = Color.DodgerBlue;
                    i++;
                }
                if (idler[i] == "2" && koltuklar[i] == "1")
                {
                    button18.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "2" && koltuklar[i] == "0")
                {
                    button18.BackColor = Color.DodgerBlue;
                    i++;
                }
                if (idler[i] == "3" && koltuklar[i] == "1")
                {
                    button21.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "3" && koltuklar[i] == "0")
                {
                    button21.BackColor = Color.DodgerBlue;
                    i++;

                }
                if (idler[i] == "4" && koltuklar[i] == "1")
                {
                    button24.BackColor = Color.Gainsboro;
                    i++;

                }
                if (idler[i] == "4" && koltuklar[i] == "0")
                {
                    button24.BackColor = Color.DodgerBlue;
                    i++;
                }
                if (idler[i] == "5" && koltuklar[i] == "1")
                {
                    button27.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "5" && koltuklar[i] == "0")
                {
                    button27.BackColor = Color.DodgerBlue;
                    i++;
                }
                if (idler[i] == "6" && koltuklar[i] == "1")
                {
                    button26.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "6" && koltuklar[i] == "0")
                {
                    button26.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "7" && koltuklar[i] == "1")
                {
                    button29.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "7" && koltuklar[i] == "0")
                {
                    button29.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "8" && koltuklar[i] == "1")
                {
                    button30.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "8" && koltuklar[i] == "0")
                {
                    button30.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "9" && koltuklar[i] == "1")
                {
                    button31.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "9" && koltuklar[i] == "0")
                {
                    button31.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "10" && koltuklar[i] == "1")
                {
                    button32.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "10" && koltuklar[i] == "0")
                {
                    button32.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "11" && koltuklar[i] == "1")
                {
                    button33.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "11" && koltuklar[i] == "0")
                {
                    button33.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "12" && koltuklar[i] == "1")
                {
                    button34.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "12" && koltuklar[i] == "0")
                {
                    button34.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "13" && koltuklar[i] == "1")
                {
                    button35.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "13" && koltuklar[i] == "0")
                {
                    button35.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "14" && koltuklar[i] == "1")
                {
                    button36.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "14" && koltuklar[i] == "0")
                {
                    button36.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "15" && koltuklar[i] == "1")
                {
                    button37.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "15" && koltuklar[i] == "0")
                {
                    button37.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "16" && koltuklar[i] == "1")
                {
                    button70.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "16" && koltuklar[i] == "0")
                {
                    button70.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "17" && koltuklar[i] == "1")
                {
                    button71.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "17" && koltuklar[i] == "0")
                {
                    button71.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "18" && koltuklar[i] == "1")
                {
                    button72.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "18" && koltuklar[i] == "0")
                {
                    button72.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "19" && koltuklar[i] == "1")
                {
                    button73.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "19" && koltuklar[i] == "0")
                {
                    button73.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "20" && koltuklar[i] == "1")
                {
                    button74.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "20" && koltuklar[i] == "0")
                {
                    button74.BackColor = Color.DodgerBlue;
                    i++;
                }
                if (idler[i] == "21" && koltuklar[i] == "1")
                {
                    button75.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "21" && koltuklar[i] == "0")
                {
                    button75.BackColor = Color.DodgerBlue;
                    i++;
                }
                if (idler[i] == "22" && koltuklar[i] == "1")
                {
                    button82.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "22" && koltuklar[i] == "0")
                {
                    button82.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "23" && koltuklar[i] == "1")
                {
                    button83.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "23" && koltuklar[i] == "0")
                {
                    button83.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "24" && koltuklar[i] == "1")
                {
                    button84.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "24" && koltuklar[i] == "0")
                {
                    button84.BackColor = Color.DodgerBlue;
                    i++;
                }
                if (idler[i] == "25" && koltuklar[i] == "1")
                {
                    button85.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "25" && koltuklar[i] == "0")
                {
                    button85.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "26" && koltuklar[i] == "1")
                {
                    button86.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "26" && koltuklar[i] == "0")
                {
                    button86.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "27" && koltuklar[i] == "1")
                {
                    button87.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "27" && koltuklar[i] == "0")
                {
                    button87.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "28" && koltuklar[i] == "1")
                {
                    button88.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "28" && koltuklar[i] == "0")
                {
                    button88.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "29" && koltuklar[i] == "1")
                {
                    button90.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "29" && koltuklar[i] == "0")
                {
                    button90.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "30" && koltuklar[i] == "1")
                {
                    button91.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "30" && koltuklar[i] == "0")
                {
                    button91.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "31" && koltuklar[i] == "1")
                {
                    button93.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "31" && koltuklar[i] == "0")
                {
                    button93.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "32" && koltuklar[i] == "1")
                {
                    button94.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "32" && koltuklar[i] == "0")
                {
                    button94.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "33" && koltuklar[i] == "1")
                {
                    button96.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "33" && koltuklar[i] == "0")
                {
                    button96.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "34" && koltuklar[i] == "1")
                {
                    button97.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "34" && koltuklar[i] == "0")
                {
                    button97.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "35" && koltuklar[i] == "1")
                {
                    button99.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "35" && koltuklar[i] == "0")
                {
                    button99.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "36" && koltuklar[i] == "1")
                {
                    button100.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "36" && koltuklar[i] == "0")
                {
                    button100.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "37" && koltuklar[i] == "1")
                {
                    button101.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "37" && koltuklar[i] == "0")
                {
                    button101.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "38" && koltuklar[i] == "1")
                {
                    button102.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "38" && koltuklar[i] == "0")
                {
                    button102.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "39" && koltuklar[i] == "1")
                {
                    button105.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "39" && koltuklar[i] == "0")
                {
                    button105.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "40" && koltuklar[i] == "1")
                {
                    button128.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "40" && koltuklar[i] == "0")
                {
                    button128.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "41" && koltuklar[i] == "1")
                {
                    button132.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "41" && koltuklar[i] == "0")
                {
                    button132.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "42" && koltuklar[i] == "1")
                {
                    button137.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "42" && koltuklar[i] == "0")
                {
                    button137.BackColor = Color.DodgerBlue;
                    i++;
                }

                if (idler[i] == "43" && koltuklar[i] == "1")
                {
                    button140.BackColor = Color.Gainsboro;
                    i++;
                }
                if (idler[i] == "43" && koltuklar[i] == "0")
                {
                    button140.BackColor = Color.DodgerBlue;
                    i++;
                }



            }
            baglantim.Close();


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            KoltuklarıCek();

            button15.Name = "1"; button18.Name = "2"; button21.Name = "3"; button24.Name = "4"; button27.Name = "5";
            button26.Name = "6"; button29.Name = "7"; button30.Name = "8"; button31.Name = "9"; button32.Name = "10";
            button33.Name = "11"; button34.Name = "12"; button35.Name = "13"; button36.Name = "14"; button37.Name = "15";
            button70.Name = "16"; button71.Name = "17"; button72.Name = "18"; button73.Name = "19"; button74.Name = "20";
            button75.Name = "21"; button82.Name = "22"; button83.Name = "23"; button84.Name = "24"; button85.Name = "25";
            button86.Name = "26"; button87.Name = "27"; button88.Name = "28"; button90.Name = "29"; button91.Name = "30";
            button93.Name = "31"; button94.Name = "32"; button96.Name = "33"; button97.Name = "34"; button99.Name = "35";
            button100.Name = "36"; button101.Name = "37"; button102.Name = "38"; button105.Name = "39"; button128.Name = "40";
            button132.Name = "41"; button137.Name = "42"; button140.Name = "43";
            KoltuklarıGüncelle();

        }
        string[] idler2 = new string[43];
        public string koltukisim;
        private void KoltuklarıGüncelle()
        {

            idler2[0] = button15.Name; idler2[1] = button18.Name; idler2[2] = button21.Name; idler2[3] = button24.Name;
            idler2[4] = button27.Name; idler2[5] = button26.Name; idler2[6] = button29.Name; idler2[7] = button30.Name;
            idler2[8] = button31.Name; idler2[9] = button32.Name; idler2[10] = button33.Name; idler2[11] = button34.Name;
            idler[12] = button35.Name; idler2[13] = button36.Name; idler2[14] = button37.Name; idler2[15] = button70.Name;
            idler2[16] = button71.Name; idler2[17] = button72.Name; idler2[18] = button73.Name; idler2[19] = button74.Name;
            idler2[20] = button75.Name; idler2[21] = button82.Name; idler2[22] = button83.Name; idler2[23] = button84.Name;
            idler2[24] = button85.Name; idler2[25] = button86.Name; idler2[26] = button87.Name; idler2[27] = button88.Name;
            idler2[28] = button90.Name; idler2[29] = button91.Name; idler2[30] = button93.Name; idler2[31] = button94.Name;
            idler2[32] = button96.Name; idler2[33] = button97.Name; idler2[34] = button99.Name; idler2[35] = button100.Name;
            idler2[36] = button101.Name; idler2[37] = button102.Name; idler2[38] = button105.Name; idler2[39] = button128.Name;
            idler2[40] = button132.Name; idler2[41] = button137.Name; idler2[42] = button140.Name;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            koltukisim = "5D";
            button15.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set Koltukdurumu ='" + 1 + "'where id='" + idler2[0] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            koltukisim = "6D";
            button18.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu ='" + 1 + "'where id='" + idler2[1] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            koltukisim = "7D";
            button21.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[2] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            koltukisim = "8D";
            button24.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[3] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            koltukisim = "9D";
            button27.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[4] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            koltukisim = "9E";
            button26.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[5] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            koltukisim = "10E";
            button29.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[6] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            koltukisim = "10D";
            button30.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[7] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();

        }

        private void button31_Click(object sender, EventArgs e)
        {
            koltukisim = "11F";
            button31.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[8] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            koltukisim = "11E";
            button32.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[9] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            koltukisim = "11D";
            button33.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[10] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            koltukisim = "12F";
            button34.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[11] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            koltukisim = "12E";
            button35.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[12] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            koltukisim = "12D";
            button36.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[13] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            koltukisim = "13F";
            button37.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[14] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            koltukisim = "24F";
            button70.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[15] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();

        }

        private void button71_Click(object sender, EventArgs e)
        {
            koltukisim = "24E";
            button71.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[16] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            koltukisim = "24D";
            button72.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[17] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            koltukisim = "25F";
            button73.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[18] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            koltukisim = "25E";
            button74.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[19] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            koltukisim = "25D";
            button75.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[20] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            koltukisim = "3C";
            button82.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[21] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            koltukisim = "3B";
            button83.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[22] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            koltukisim = "3A";
            button84.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[23] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            koltukisim = "4C";
            button85.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[24] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            koltukisim = "4B";
            button86.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[25] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            koltukisim = "4A";
            button87.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[26] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            koltukisim = "5C";
            button88.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[27] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            koltukisim = "5A";
            button90.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[28] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button91_Click(object sender, EventArgs e)
        {
            koltukisim = "6C";
            button91.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[29] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            koltukisim = "6A";
            button93.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[30] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            koltukisim = "7C";
            button94.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[31] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button96_Click(object sender, EventArgs e)
        {
            koltukisim = "7A";
            button96.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[32] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();

        }

        private void button97_Click(object sender, EventArgs e)
        {
            koltukisim = "8C";
            button97.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[33] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            koltukisim = "8A";
            button99.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[34] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            koltukisim = "9C";
            button100.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[35] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            koltukisim = "9B";
            button101.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[36] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            koltukisim = "9A";
            button102.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[37] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button105_Click(object sender, EventArgs e)
        {
            koltukisim = "10A";
            button105.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[38] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button128_Click(object sender, EventArgs e)
        {
            koltukisim = "18B";
            button128.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[39] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button132_Click(object sender, EventArgs e)
        {
            koltukisim = "19A";
            button132.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[40] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button137_Click(object sender, EventArgs e)
        {
            koltukisim = "21B";
            button137.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[41] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button140_Click(object sender, EventArgs e)
        {
            koltukisim = "22B";
            button140.BackColor = Color.Red;
            baglantim.Open();
            OleDbCommand güncellekomutu = new OleDbCommand("update Koltuklar2 set koltukdurumu='" + 1 + "'where id='" + idler2[42] + "'", baglantim);
            güncellekomutu.ExecuteNonQuery();
            baglantim.Close();
        }

        private void button154_Click(object sender, EventArgs e)
        {


            baglantim.Open();
            OleDbCommand selectsorgu = new OleDbCommand("select* from Koltuklar2 ", baglantim);
            OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
            int i = 0;
            while (kayitokuma.Read())
            {


                idler[i] = kayitokuma.GetValue(0).ToString();
                koltuklar[i] = kayitokuma.GetValue(1).ToString();
                
            

            if (idler[i]=="1" && koltuklar[i]=="1")
            {
                button15.BackColor = Color.Gainsboro;
                button15.Enabled = false;
                i++;
            }

            if (idler[i]=="2" && koltuklar[i]=="1")
            {
                button18.BackColor = Color.DodgerBlue;
                button18.Enabled = false;
                i++;
            }

            if (idler[i] == "3" && koltuklar[i] == "1")
            {
                button21.BackColor = Color.DodgerBlue;
                button21.Enabled = false;
                i++;
            }
            if (idler[i] == "4" && koltuklar[i] == "1")
            {
                button24.BackColor = Color.DodgerBlue;
                button24.Enabled = false;
                i++;
            }
            if (idler[i] == "5" && koltuklar[i] == "1")
            {
                button27.BackColor = Color.DodgerBlue;
                button27.Enabled = false;
                i++;
            }

            if (idler[i] == "6" && koltuklar[i] == "1")
            {
                button26.BackColor = Color.DodgerBlue;
                button26.Enabled = false;
                i++;
                i++;
            }
            if (idler[i] == "7" && koltuklar[i] == "1")
            {
                button29.BackColor = Color.DodgerBlue;
                button29.Enabled = false;
                i++;
            }
            if (idler[i] == "8" && koltuklar[i] == "1")
            {
                button30.BackColor = Color.DodgerBlue;
                button30.Enabled = false;
                i++;
            }
            if (idler[i] == "9" && koltuklar[i] == "1")
            {
                button31.BackColor = Color.DodgerBlue;
                button31.Enabled = false;
                i++;
            }
            if (idler[i] == "10" && koltuklar[i] == "1")
            {
                button32.BackColor = Color.DodgerBlue;
                button32.Enabled = false;
                i++;
            }
            if (idler[i] == "11" && koltuklar[i] == "1")
            {
                button33.BackColor = Color.DodgerBlue;
                button33.Enabled = false;
                i++;
            }
            if (idler[i] == "12" && koltuklar[i] == "1")
            {
                button34.BackColor = Color.DodgerBlue;
                button34.Enabled = false;
                i++;
            }
            if (idler[i] == "13" && koltuklar[i] == "1")
            {
                button35.BackColor = Color.DodgerBlue;
                button35.Enabled = false;
                i++;
            }
            if (idler[i] == "14" && koltuklar[i] == "1")
            {
                button36.BackColor = Color.DodgerBlue;
                button36.Enabled = false;
                i++;
            }
            if (idler[i] == "15" && koltuklar[i] == "1")
            {
                button37.BackColor = Color.DodgerBlue;
                button37.Enabled = false;
                i++;
            }
            if (idler[i] == "16" && koltuklar[i] == "1")
            {
                button70.BackColor = Color.DodgerBlue;
                button70.Enabled = false;
                i++;
            }
            if (idler[i] == "17" && koltuklar[i] == "1")
            {
                button71.BackColor = Color.DodgerBlue;
                button71.Enabled = false;
                i++;
            }
            if (idler[i] == "18" && koltuklar[i] == "1")
            {
                button72.BackColor = Color.DodgerBlue;
                button72.Enabled = false;
                i++;
            }
            if (idler[i] == "19" && koltuklar[i] == "1")
            {
                button73.BackColor = Color.DodgerBlue;
                button73.Enabled = false;
                i++;
            }
            if (idler[i] == "20" && koltuklar[i] == "1")
            {
                button74.BackColor = Color.DodgerBlue;
                button74.Enabled = false;
                i++;
            }
            if (idler[i] == "21" && koltuklar[i] == "1")
            {
                button75.BackColor = Color.DodgerBlue;
                button75.Enabled = false;
                i++;
            }
            if (idler[i] == "22" && koltuklar[i] == "1")
            {
                button82.BackColor = Color.DodgerBlue;
                button82.Enabled = false;
                i++;
            }
            if (idler[i] == "23" && koltuklar[i] == "1")
            {
                button83.BackColor = Color.DodgerBlue;
                button83.Enabled = false;
                i++;
            }
            if (idler[i] == "24" && koltuklar[i] == "1")
            {
                button84.BackColor = Color.DodgerBlue;
                button84.Enabled = false;
                i++;
            }
            if (idler[i] == "25" && koltuklar[i] == "1")
            {
                button85.BackColor = Color.DodgerBlue;
                button85.Enabled = false;
                i++;
            }
            if (idler[i] == "26" && koltuklar[i] == "1")
            {
                button86.BackColor = Color.DodgerBlue;
                button86.Enabled = false;
                i++;
            }
            if (idler[i] == "27" && koltuklar[i] == "1")
            {
                button87.BackColor = Color.DodgerBlue;
                button87.Enabled = false;
                i++;
            }
            if (idler[i] == "28" && koltuklar[i] == "1")
            {
                button88.BackColor = Color.DodgerBlue;
                button88.Enabled = false;
                i++;
            }
            if (idler[i] == "29" && koltuklar[i] == "1")
            {
                button90.BackColor = Color.DodgerBlue;
                button90.Enabled = false;
                i++;
            }
            if (idler[i] == "30" && koltuklar[i] == "1")
            {
                button91.BackColor = Color.DodgerBlue;
                button91.Enabled = false;
                i++;
            }
            if (idler[i] == "31" && koltuklar[i] == "1")
            {
                button93.BackColor = Color.DodgerBlue;
                button93.Enabled = false;
                i++;
            }
            if (idler[i] == "32" && koltuklar[i] == "1")
            {
                button94.BackColor = Color.DodgerBlue;
                button94.Enabled = false;
                i++;
            }
            if (idler[i] == "33" && koltuklar[i] == "1")
            {
                button96.BackColor = Color.DodgerBlue;
                button96.Enabled = false;
                i++;
            }
            if (idler[i] == "34" && koltuklar[i] == "1")
            {
                button97.BackColor = Color.DodgerBlue;
                button97.Enabled = false;
                i++;
            }
            if (idler[i] == "35" && koltuklar[i] == "1")
            {
                button99.BackColor = Color.DodgerBlue;
                button99.Enabled = false;
                i++;
            }
            if (idler[i] == "36" && koltuklar[i] == "1")
            {
                button100.BackColor = Color.DodgerBlue;
                button100.Enabled = false;
                i++;
            }
            if (idler[i] == "37" && koltuklar[i] == "1")
            {
                button101.BackColor = Color.DodgerBlue;
                button101.Enabled = false;
                i++;
            }
            if (idler[i] == "38" && koltuklar[i] == "1")
            {
                button102.BackColor = Color.DodgerBlue;
                button102.Enabled = false;
                i++;
            }
            if (idler[i] == "39" && koltuklar[i] == "1")
            {
                button105.BackColor = Color.DodgerBlue;
                button105.Enabled = false;
                i++;
            }
            if (idler[i] == "40" && koltuklar[i] == "1")
            {
                button128.BackColor = Color.DodgerBlue;
                button128.Enabled = false;
                i++;
            }
            if (idler[i] == "41" && koltuklar[i] == "1")
            {
                button132.BackColor = Color.DodgerBlue;
                button132.Enabled = false;
                i++;
            }
            if (idler[i] == "42" && koltuklar[i] == "1")
            {
                button137.BackColor = Color.DodgerBlue;
                button137.Enabled = false;
                i++;
            }
            if (idler[i] == "43" && koltuklar[i] == "1")
            {
                button140.BackColor = Color.DodgerBlue;
                button140.Enabled = false;
                i++;

            }
        }

            MessageBox.Show("Biletme İşlemi Başarılı İyi Uçuşlar Dileriz...", "Uçak Bileti Satış Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglantim.Close();
    

    }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.textBox1.Text = koltukisim;
            this.Hide();
            frm2.Show();
        }
    }
}