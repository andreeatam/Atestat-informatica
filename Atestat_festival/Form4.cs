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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text!="")
            { 
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
            }
            if (comboBox1.Text == "Romana")
            {
                
                pictureBox1.Image = imageList1.Images[1];
                label3.Text = "" + this.reprezentantiTableAdapter.Nume(1);
                label4.Text = "" + this.reprezentantiTableAdapter.Prenume(1);
                label5.Text = "" + this.reprezentantiTableAdapter.AdresaEmail(1);
                label6.Text = "" + this.reprezentantiTableAdapter.NrTelefon(1);
            }
            if (comboBox1.Text == "Engleza")
            {
                pictureBox1.Image = imageList1.Images[0];
                label3.Text = "" + this.reprezentantiTableAdapter.Nume(2);
                label4.Text = "" + this.reprezentantiTableAdapter.Prenume(2);
                label5.Text = "" + this.reprezentantiTableAdapter.AdresaEmail(2);
                label6.Text = "" + this.reprezentantiTableAdapter.NrTelefon(2);
            }
            if (comboBox1.Text == "Germana")
            {
                pictureBox1.Image = imageList1.Images[2];
                label3.Text = "" + this.reprezentantiTableAdapter.Nume(3);
                label4.Text = "" + this.reprezentantiTableAdapter.Prenume(3);
                label5.Text = "" + this.reprezentantiTableAdapter.AdresaEmail(3);
                label6.Text = "" + this.reprezentantiTableAdapter.NrTelefon(3);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDfestivalDataSet.Reprezentanti' table. You can move, or remove it, as needed.
            this.reprezentantiTableAdapter.Fill(this.bDfestivalDataSet.Reprezentanti);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
