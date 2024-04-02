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
    public partial class Login_Menu : Form
    {
        public Login_Menu()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\moham\Downloads\TTR Test - Teams (1) - Copy\TTR Test - Teams (1) - Copy\TTR Test\TTR Test\Login Database.mdf; Integrated Security = True");
            con.Open();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (Username_textBox.Text == "" || Password_textBox.Text == "")
            {
                MessageBox.Show("Please provide your UserName and Password");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\moham\Downloads\TTR Test - Teams (1) - Copy\TTR Test - Teams (1) - Copy\TTR Test\TTR Test\Login Database.mdf; Integrated Security = True");
                SqlCommand cmd = new SqlCommand("Select * from [Student_Login] where UserName=@Username and Password=@Password", con);
                cmd.Parameters.AddWithValue(@"Username", Username_textBox.Text);

                cmd.Parameters.AddWithValue(@"Password", Password_textBox.Text);
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
                    Main_Menu fm = new Main_Menu();
                    fm.Show();
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

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            Password_textBox.PasswordChar = '*';
        }
    }
}
