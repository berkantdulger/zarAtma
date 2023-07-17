using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace zarAtma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Salla";
            button2.Text = "At";
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            button1.Visible = false;
            button2.Visible = true;
            timer1.Start();
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button1.Visible = true;
            button2.Visible = false;

            listBox1.Items.Add = (a);


            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            Random r = new Random();

            int a = r.Next(0, 6);
            int b = r.Next(0, 6);


            pictureBox1.Image = ımageList1.Images[a];
            pictureBox2.Image = ımageList1.Images[b];
        }
    }
}
