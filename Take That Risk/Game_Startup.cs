using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TTR_Test
{
    public partial class Game_Startup : Form
    {
        public Game_Startup()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Category frm8 = new Category();
            this.Hide();
            frm8.ShowDialog();
            this.Show();
        }
    }
}
