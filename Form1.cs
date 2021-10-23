using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışıOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birsol, ikisol, ucsol;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birgenislik = pictureBox1.Width;
            int ikigenislik = pictureBox2.Width;
            int ucgenislik = pictureBox3.Width;
            int sure = Convert.ToInt32(label7.Text);
            sure++;
            label7.Text = sure.ToString();

            int bitis = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 16);
            pictureBox3.Left += rastgele.Next(5, 16);

            if (pictureBox1.Left >pictureBox2.Left+5 && pictureBox1.Left > pictureBox3.Left+5)
            {
                label6.Text = "1 NUMARALI AT YARIŞI ÖNDE GÖTÜRÜYOR";
            }
            if (pictureBox2.Left > pictureBox1.Left+5 && pictureBox2.Left > pictureBox3.Left+5)
            {
                label6.Text = " 2 NUMARALI AT BÜYÜK BİR ATAKLA ÖNE GEÇİYOR";
            }
            if (pictureBox3.Left > pictureBox1.Left+5 && pictureBox3.Left >pictureBox2.Left +5)
            {
                label6.Text = "3 NUMARALI AT ÇOK HIZLI GELİYOR";
            }

            if (birgenislik + pictureBox1.Left >= bitis)
            {
                timer1.Enabled = false;
                label6.Text="1 NUMARALI AT KAZANDI!!!.";               
            }
            if (ikigenislik+pictureBox2.Left >= bitis)
            {
                timer1.Enabled = false;
                label6.Text="2 NUMARALI AT KAZANDI!!!.";

            }
            if (ucgenislik+pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                label6.Text="3 NUMARALI AT KAZANDI!!!.";

            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label6.Text = " ";
            label7.Text = "0";
        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birsol = pictureBox1.Left;
            ikisol = pictureBox2.Left;
            ucsol = pictureBox3.Left;
        }
    }
}
