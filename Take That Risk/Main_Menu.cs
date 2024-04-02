using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTR_Test
{
    public partial class Main_Menu : Form
    {
        public object Content { get; private set; }

        public Main_Menu()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            //UserControl1 pm = new UserControl1();
            //showControl(pm);
            Game_Startup frm2 = new Game_Startup();
            this.Hide();
            frm2.ShowDialog();
            this.Show();
        }

        private void Create_Account_button_Click_1(object sender, EventArgs e)
        {
            //UserControl1 pm = new UserControl1();
            //showControl(pm);
            Create_Account_Menu frm3 = new Create_Account_Menu();
            this.Hide();
            frm3.ShowDialog();
            this.Show();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Login_Menu frm4 = new Login_Menu();
            this.Hide();
            frm4.ShowDialog();
            this.Show();
        }

        private void Teacher_Login_button_Click(object sender, EventArgs e)
        {
            Teacher_Login_Menu frm5 = new Teacher_Login_Menu();
            this.Hide();
            frm5.ShowDialog();
            this.Show();
        }
    }
}
