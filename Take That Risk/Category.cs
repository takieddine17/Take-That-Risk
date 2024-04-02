using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TTR_Test
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Maths_button_Click(object sender, EventArgs e)
        {
            MathsQ frm9 = new MathsQ();
            this.Hide();
            frm9.ShowDialog();
            this.Show();
        }

        private void Chemistry_button_Click(object sender, EventArgs e)
        {
            ChemistryQ frm10 = new ChemistryQ();
            this.Hide();
            frm10.ShowDialog();
            this.Show();
        }

        private void Geography_button_Click(object sender, EventArgs e)
        {
            GeogQ frm11 = new GeogQ();
            this.Hide();
            frm11.ShowDialog();
            this.Show();
        }

        private void Sports_button_Click(object sender, EventArgs e)
        {
            SportsQ frm12 = new SportsQ();
            this.Hide();
            frm12.ShowDialog();
            this.Show();
        }

        private void General_button_Click(object sender, EventArgs e)
        {
            GeneralQ frm13 = new GeneralQ();
            this.Hide();
            frm13.ShowDialog();
            this.Show();
        }

        private void TV_button_Click(object sender, EventArgs e)
        {
            TV_Q frm14 = new TV_Q();
            this.Hide();
            frm14.ShowDialog();
            this.Show();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void End_Quiz_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
