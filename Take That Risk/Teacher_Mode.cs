using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TTR_Test
{
    public partial class Teacher_Mode : Form
    {
        public Teacher_Mode()
        {
            InitializeComponent();
        }

        private void Maths_button_Click(object sender, EventArgs e)
        {
            M_Add frm15 = new M_Add();
            this.Hide();
            frm15.ShowDialog();
            this.Show();
        }

        private void Chemistry_button_Click(object sender, EventArgs e)
        {
            C_Add frm16 = new C_Add();
            this.Hide();
            frm16.ShowDialog();
            this.Show();
        }

        private void Geography_button_Click(object sender, EventArgs e)
        {
            G_Add frm17 = new G_Add();
            this.Hide();
            frm17.ShowDialog();
            this.Show();
        }

        private void TV_button_Click(object sender, EventArgs e)
        {
            TV_Add frm18 = new TV_Add();
            this.Hide();
            frm18.ShowDialog();
            this.Show();
        }

        private void Sports_button_Click(object sender, EventArgs e)
        {
            S_Add frm19 = new S_Add();
            this.Hide();
            frm19.ShowDialog();
            this.Show();
        }

        private void General_button_Click(object sender, EventArgs e)
        {
            Ge_Add frm20 = new Ge_Add();
            this.Hide();
            frm20.ShowDialog();
            this.Show();
        }

        private void End_Quiz_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
