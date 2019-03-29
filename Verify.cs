using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Marks_Upload_System
{
    public partial class Verify : Form
    {
        public MySqlConnection con;
        public string name2;
        public Verify(MySqlConnection c)
        {
            con = c;
            InitializeComponent();
            namel.Text = name2;
        }

        public void pic_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Closing Connection");
                con.Close();
                Console.WriteLine("Connection Closed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Upload u = new Upload(con);
            this.Hide();
            u.namel.Text = name2;
            u.ShowDialog();
        }

        private void outof_Click(object sender, EventArgs e)
        {

        }
    }
}
