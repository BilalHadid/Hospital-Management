using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            panelDotor2.Visible = false;
            panelDocter.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            paneRecepetionist.Visible = true;
            paneRecepetionist2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            panelAdmin2.Visible = true;
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxAdmin.Checked)
            {
                textBoxpwAdmin.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxpwAdmin.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelAdmin.Visible = true;
            panelAdmin2.Visible = false;
           
        }

        private void panelDotor2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelDocter.Visible = false;
            panelDotor2.Visible = true;
           
        }

        private void checkBoxDocter_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxDocter.Checked)
            {
                textBoxpwDocter.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxpwDocter.UseSystemPasswordChar = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            paneRecepetionist.Visible = false;
            paneRecepetionist2.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecep.Checked)
            {
                textBoxpwRecep.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxpwRecep.UseSystemPasswordChar = false;
            }
        }

        private void paneRecepetionist2_Paint(object sender, PaintEventArgs e)
        {

        }

        public  void button5_Click(object sender, EventArgs e)
        {
            string c = "SELECT* from login WHERE user_name = @user and password = @pw";
            string a = textBoxadminame.Text;
            string b = textBoxpwAdmin.Text;
            Program.connection(c,a,b);
            textBoxadminame.Clear();
            textBoxpwAdmin.Clear();
        }

        private void panelAdmin2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string c = "SELECT* from log_docter WHERE user_name = @user and password = @pw";
            string a = textBox7.Text;
            string b = textBoxpwDocter.Text;
            Program.connection(c,a,b);
            textBox7.Clear();
            textBoxpwDocter.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string c = "SELECT* from login WHERE user_name = @user and password = @pw";
            string a = textBox3.Text;
            string b = textBoxpwRecep.Text;
            Program.connection(c,a, b);
            textBox3.Clear();
            textBoxpwRecep.Clear();
        }
    }
}
