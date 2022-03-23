using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form3 = new Form3();
            form3.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form playersmain = new playersmain();
            playersmain.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form matchuplist = new matchuplist();
            matchuplist.Show();
        }
    }
}
