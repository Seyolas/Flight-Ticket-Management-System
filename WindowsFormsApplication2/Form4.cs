using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked==true)
            {

                this.Hide();
                Form frm6 = new Form6();
                frm6.Show();

            }
            else if (radioButton3.Checked==true)
            {
                this.Hide();
                Form5 frm5 = new Form5();
                frm5.Show();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                this.Hide();
                Form6 frm6 = new Form6();
                frm6.Show();

                
            }
            else if (radioButton2.Checked==true)
            {

                this.Hide();
                Form5 frm5 = new Form5();
                frm5.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked==true)
            {
               this.Hide();
                Form5 frm5 = new Form5();
                frm5.Show();


            }
            else if (radioButton5.Checked==true)
            {
                 this.Hide();
                Form6 frm6 = new Form6();
                frm6.Show();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked==true)
            {

                this.Hide();
                Form6 frm6 = new Form6();
                frm6.Show();

            }
            else if (radioButton8.Checked==true)
            {
                 this.Hide();
                Form5 frm5 = new Form5();
                frm5.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked==true)
            {
                 this.Hide();
                Form6 frm6 = new Form6();
                frm6.Show();
            }
            else if (radioButton10.Checked==true)
            {

                this.Hide();
                Form5 frm5 = new Form5();
                frm5.Show();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (Form1.yetki=="misafir")
            {

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
               

            }
        }
    }
}
