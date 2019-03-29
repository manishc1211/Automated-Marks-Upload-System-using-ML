using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Marks_Upload_System
{
    public partial class Login : Form
    {
        public MySqlConnection conn;
        string id, pass;
        public string connstring, name;
        int flag = 0,click = 0;

        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            connstring = "SERVER=65.19.141.67;PORT=3306;DATABASE=**********;UID=********; PASSWORD=*********;";
            if (!logl.Text.Equals(""))
            {
                if (!passl.Text.Equals(""))
                {
                    id = logl.Text;
                    pass = passl.Text;
                    
                    try
                    {
                        if(click == 1)
                        {
                            Console.WriteLine("Closing Connection");
                            conn.Close();
                            click = 0;
                            Console.WriteLine("Connection Closed");
                        }
                        if(click == 0)
                        {
                            try
                            {
                                t1.Start();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error");
                            }
                            conn = new MySqlConnection();
                            conn.ConnectionString = connstring;
                            Console.WriteLine("Connecting");
                            conn.Open();
                            click = 1;
                            Console.WriteLine("Success");
                            //t2.Start();
                            //t2.Abort();
                            try
                            {
                                t1.Abort();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error");
                            }
                        }

                        string query = "SELECT * FROM emp";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            if (id.Equals(dataReader["id" + ""]))
                            {
                                flag = 1;
                                break;
                            }
                        }                        

                        if (flag == 1)
                        {
                            if (pass.Equals(dataReader["pwd" + ""]))
                            {
                                name = (string)dataReader["name" + ""];

                                Upload v = new Upload(conn);
                                v.name1 = name;
                                v.namel.Text = name;
                                this.Hide();
                                v.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Password Mismatch", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You are not authorised to access.", "Error");
                        }

                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }

                }
                else
                {
                    MessageBox.Show("Plaese Enter Password", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Employee ID", "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void passl_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class MyThread
    {
        public loading lod = new loading();
        public void Thread1()
        {
            lod.ShowDialog();
        }
        public void Thread2()
        {
            lod.Hide();
            lod.Close();
            this.lod.Hide();
        }
    }
}
