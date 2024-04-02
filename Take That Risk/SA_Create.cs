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
    public partial class SA_Create : Form
    {
        SqlConnection con;
        public SA_Create()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SA_Create_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\S201304\Downloads\TTR Test\TTR Test\Login Database.mdf; Integrated Security = True");
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            if (Cnfrm_textBox.Text != string.Empty || Password_textBox.Text != string.Empty || UserN_textBox.Text != string.Empty)
            {
                if (Password_textBox.Text == Cnfrm_textBox.Text)
                {
                    //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\S201304\OneDrive - Altus Education Partnership\Desktop\Computer Science Y1\TTR Test 2\TTR Test\TTR Test\Login Database.mdf; Integrated Security = True");

                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from [Student_Login] where Username='" + UserN_textBox.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exists, please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Student_Login values(@Username,@Password)", con);
                        cmd.Parameters.AddWithValue("Username", UserN_textBox.Text);
                        cmd.Parameters.AddWithValue("Password", Password_textBox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please enter the same password in both boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
