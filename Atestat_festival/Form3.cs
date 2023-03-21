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
    public partial class Form3 : Form
    {
        int a = 0;
        string pret = "0 euro"; // daca utilizatorul doreste sa vada pretul, dar nu a selectat nimic 
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pret = "0 euro";          //daca utilizatorul a ales ceva si s-a razgandit, pretul nu va ramane de la alegerea anterioara 
            label3.Visible = false;
            if (comboBox1.Text == "Toate zilele")
            {
                radioButton1.Checked = false;       //cand utilizatorul alege din combobox, se deselecteaza radiobutton
                radioButton2.Checked = false;
                a = 1;                      //daca a ales "toate zilele", cand selecteaza in radiobutton poate alege VIP sau clasic
            }
            else
            {
                radioButton1.Checked = false;       //cand alege din combobox, se deselecteaza radiobutton
                radioButton2.Checked = false;
                a = 2;     //daca utilizatorul nu a ales "toate zilele", cand doreste sa selecteze in radiobutton nu va putea alege nici VIP, nici clasic        
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)             
            {
                label5.Visible = false;
                if (a == 2)             //daca a ales bilet pt o zi
                {
                    radioButton1.Checked = false;           //se deselecteaza bilet VIP
                    radioButton2.Checked = true;             //se selecteaza automat bilet clasic
                    label3.Visible = true;          //se afiseaza mesajul ca biletele pt o zi nu sunt disponibile VIP 
                    pret = "45 euro";               //pret bilet clasic pt o zi
                }
                else
                    pret = "200 euro";        //pret bilet vip pt toate zilele          
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;          
            label5.Text = pret;
            if (pret != "0 euro")             //daca utilizatorul are o suma valida (pretul diferit de 0)
            {
               
                label6.Visible = true;
                radioButton3.Visible = true;       //apare metoda de plata
                radioButton4.Visible = true;
                    
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)   
            {
                label5.Visible = false;
                label3.Visible = false;          //daca utilizatorul a ales bilet VIP, si se rasgandeste la cel clasic, mesajul va disparea 
                if (a == 1)
                    pret = "150 euro";             //pret bilet clasic pt toate zilele
                if (a == 2)
                    pret = "45 euro";          //pret (automat clasic) pt o zi
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Image = imageList1.Images[1];
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = imageList1.Images[0];
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Image = imageList1.Images[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label6.Visible == true)
                if (radioButton3.Checked == true || radioButton4.Checked == true)
                {
                    label10.Visible = false;        //dispare mesajul ca nu a fost selectata plata
                    label9.Visible = false;        //dispare mesajul ca nu a fost selectat niciun bilet
                    label8.Visible = true;          //apare mesajul ca biletul a fost inregistrat cu success
                }
                else
                {
                    label9.Visible=false;
                    label10.Visible = true;
                }
            else
                label9.Visible = true;
            
        }
    }
}
