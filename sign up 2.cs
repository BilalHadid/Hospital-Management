using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_hospital
{
    public partial class sign_up_2 : Form
    {
        public sign_up_2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxpw2.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxpw2.UseSystemPasswordChar = false;
            }
        }

        private void sign_up_2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxpw2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
