using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        } 

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        } 

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
