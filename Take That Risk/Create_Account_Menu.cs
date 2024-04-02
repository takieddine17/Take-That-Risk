using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TTR_Test
{
    public partial class Create_Account_Menu : Form
    {
        public Create_Account_Menu()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SA_Create frm6 = new SA_Create();
            this.Hide();
            frm6.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TA_Create frm7 = new TA_Create();
            this.Hide();
            frm7.ShowDialog();
            this.Show();
        }
    }
}
