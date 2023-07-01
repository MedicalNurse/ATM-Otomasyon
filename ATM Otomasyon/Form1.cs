using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int yanlisgirissayisi = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre1 = textBox1.Text;

            int sifre = int.Parse(textBox1.Text);

            if (sifre == 123456)
            {
                MessageBox.Show("Şifrenizi doğru tuşladınız, ana menüye yönlendiriliyorsunuz...", "GüvenBank");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }

            else
            {
                yanlisgirissayisi++;

                if (yanlisgirissayisi == 1)
                {
                    DialogResult result2 = MessageBox.Show("Şifrenizi eksik veya hatalı girdiniz. Tekrar denemek ister misiniz? Kalan Hakkınız: 2", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    { 
                        textBox1.Clear();
                    }

                    else if (result2 == DialogResult.No)
                        Application.Exit();
                }


                if (yanlisgirissayisi == 2)
                {
                    DialogResult result1 = MessageBox.Show("Şifrenizi eksik veya hatalı girdiniz. Tekrar denemek ister misiniz? Kalan Hakkınız: 1", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    textBox1.Clear();

                    if (result1 == DialogResult.Yes)
                    {
                        textBox1.Clear();
                    }    

                    else if (result1 != DialogResult.No)
                    {
                        Application.Exit();
                    }

                }


                if (yanlisgirissayisi == 3)
                {
                    MessageBox.Show("Şifrenizi 3 defa eksik veya hatalı tuşladınız. Çıkış yapılıyor...");
                    Application.Exit();
                }


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih ettiğiniz için teşekkür ederiz...");
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
