using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_hospital
{
    static class Program
    {
        public static void connection(string c,string a,string b)
        {
            try
            {
                SqlConnection sql = new SqlConnection("Data Source=DESKTOP-I6PVHQ4;Initial Catalog=hospital;Integrated Security=True");
                SqlCommand com = new SqlCommand(c, sql);
                sql.Open();
                com.Parameters.AddWithValue("@user", a);
                com.Parameters.AddWithValue("@pw", b);
                SqlDataReader read = com.ExecuteReader();
                if (read.HasRows == true)
                {
                    MessageBox.Show("Corrected");
                }
                else
                {
                    MessageBox.Show("Check your user name && Password...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
     
    }
}
