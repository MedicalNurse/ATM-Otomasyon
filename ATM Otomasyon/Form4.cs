using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Otomasyon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih ettiğiniz için teşekkür ederiz...");
            Application.Exit();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            double bakiyesayisi4 = Convert.ToDouble(label5.Text);
            double girilendeger4 = Convert.ToDouble (textBox1.Text);
            double label7texti4 = Convert.ToDouble(label7.Text);
            double toplam4 = label7texti4 +bakiyesayisi4 + girilendeger4;


            int progressStep = 1;
            int progressDelay = 10;

            for (int i = 0; i <= progressBar1.Maximum; i += progressStep)
            {
                progressBar1.Value = i;

                await Task.Delay(progressDelay);
            }


            DialogResult soru = MessageBox.Show("Hesabınıza " + girilendeger4 + " TRY yatırılacaktır. Onaylıyor musunuz? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (soru == DialogResult.Yes)
            {
                MessageBox.Show("Hesabınıza " + girilendeger4 + " TRY yatırılmıştır.", "Bilgilendirme");
                label7.Text = toplam4.ToString();
                label6.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
            }

            else if (soru == DialogResult.No)
            {
                textBox1.Clear();
                label7.Text = "0";
                label6.Visible = false;
                label7.Visible = false;
                label9.Visible= false;

            }








        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
