using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_festival
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Image = imageList1.Images[1];
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Image = imageList1.Images[3];
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Image = imageList1.Images[5];
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = imageList1.Images[0];
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = imageList1.Images[2];
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Image = imageList1.Images[4];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Image = imageList1.Images[0];
            button2.Image = imageList1.Images[2];
            button4.Image = imageList1.Images[4];
        }
    }
}
