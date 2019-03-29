using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Marks_Upload_System
{
    public partial class Upload : Form
    {
        public MySqlConnection con;
        public string name1;
        ToolTip tip = new ToolTip();


        public Upload(MySqlConnection c)
        {
            con = c;
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string str = ofd.FileName;
                string png = "^*.png$";
                string jpg = "^*.jpg$";
                string jpeg = "^*.jpeg$";
                bool pngb = Regex.IsMatch(str, png);
                bool jpgb = Regex.IsMatch(str, jpg);
                bool jpegb = Regex.IsMatch(str, jpeg);
                if (pngb | jpgb | jpegb)
                {
                    fileadd.Text = str;
                }
                else
                {
                    MessageBox.Show("Please select file in jpg / jpeg / png format.", "Error");
                }
            }
        }

        private void uploadbutton_Click(object sender, EventArgs e)
        {
            string str = fileadd.Text;
            string png = "^*.png$";
            string jpg = "^*.jpg$";
            string jpeg = "^*.jpeg$";
            bool pngb = Regex.IsMatch(str, png);
            bool jpgb = Regex.IsMatch(str, jpg);
            bool jpegb = Regex.IsMatch(str, jpeg);
            if (pngb | jpgb | jpegb)
            {
                if (mte.Checked)
                {
                    this.Hide();
                    Verify u = new Verify(con);
                    u.outof.Text = "40";
                    u.pic.ImageLocation = str;
                    u.namel.Text = name1;
                    u.name2 = name1;
                    u.ShowDialog();
                }
                else if (ete.Checked)
                {
                    this.Hide();
                    Verify u = new Verify(con);
                    u.outof.Text = "100";
                    u.pic.ImageLocation = str;
                    u.namel.Text = name1;
                    u.name2 = name1;
                    u.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select Exam Type.", "Error");
                }

            }
            else
            {
                MessageBox.Show("Please select file in jpg / jpeg / png format.", "Error");
            }

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {          
            try
            {
                Console.WriteLine("Closing Connection");
                con.Close();
                Console.WriteLine("Connection Closed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void Upload_Load(object sender, EventArgs e)
        {

        }
    }
}
