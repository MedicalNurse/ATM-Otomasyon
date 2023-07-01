using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Otomasyon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih ettiğiniz için teşekkür ederiz...");
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            double bakiyesayisi5 = Convert.ToDouble(label5.Text);
            double girilendeger5 = Convert.ToDouble(textBox1.Text);
            double label8texti5 = Convert.ToDouble(label8.Text);
            double toplam5 = bakiyesayisi5 - girilendeger5 + label8texti5;


            if (toplam5 < 0)
            {
                MessageBox.Show("Hesabınıza yeteri kadar bakiye bulunmamaktadır. Lütfen bakiyeniz kadar veya daha az bir miktar giriniz.", "Uyarı");
                textBox1.Clear();

            }

            else
            {

                int progressStep = 1;
                int progressDelay = 10;

                for (int i = 0; i <= progressBar1.Maximum; i += progressStep)
                {
                    progressBar1.Value = i;

                    await Task.Delay(progressDelay);
                }


                DialogResult soru = MessageBox.Show("Hesabınızdan " + girilendeger5 + " TRY çekilecektir. Onaylıyor musunuz? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (soru == DialogResult.Yes)
                {
                    MessageBox.Show("Hesabınızdan " + girilendeger5 + " TRY çekilmiştir.", "Bilgilendirme");
                    label8.Text = toplam5.ToString();
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                }

                else if (soru == DialogResult.No)
                {
                    textBox1.Clear();
                    label8.Text = "0";
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double bakiyenintamamı5 = Convert.ToDouble(label5.Text);
            textBox1.Text = bakiyenintamamı5.ToString();
        }
    }
}
