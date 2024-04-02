using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTR_Test
{
    public partial class Teacher_Login_Menu : Form
    {
        public Teacher_Login_Menu()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\moham\OneDrive - Altus Education Partnership\Desktop\TTR Test - Teams (2) - Copy\TTR Test - Teams (1) - Copy\TTR Test - Teams (1) - Copy\TTR Test\TTR Test\Login Database.mdf; Integrated Security = True");
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (username_textBox.Text == "" || password_textBox.Text == "")
            {
                MessageBox.Show("Please provide your UserName and Password");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\moham\OneDrive - Altus Education Partnership\Desktop\TTR Test -Teams(2) - Copy\TTR Test -Teams(1) - Copy\TTR Test -Teams(1) - Copy\TTR Test\TTR Test\Login Database.mdf; Integrated Security = True");
                SqlCommand cmd = new SqlCommand("Select * from Teacher_Login where UserName=@Username and Password=@Password", con);
                cmd.Parameters.AddWithValue(@"Username", username_textBox.Text);

                cmd.Parameters.AddWithValue(@"Password", password_textBox.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Teacher_Mode frm15 = new Teacher_Mode();
                    frm15.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            password_textBox.PasswordChar = '*';
        }
    }
}
