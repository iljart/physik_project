using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    
    public partial class Form1 : Form
    {
        public static int Score;

        public Form1()
        {
            Score = 0;
            InitializeComponent();
        }
        private int btn;

        private void b1_Click(object sender, EventArgs e)
        {
            btn = 1;

            Form2 newForm = new Form2(this.btn);
            //this.WindowState = FormWindowState.Minimized;

            newForm.ShowDialog();

            //this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void b2_Click(object sender, EventArgs e)
        {

            btn = 2;

            Form2 newForm = new Form2(this.btn);
            //this.WindowState = FormWindowState.Minimized;

            newForm.ShowDialog();

            //this.WindowState = FormWindowState.Minimized;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            btn = 3;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            btn = 7;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            btn = 8;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            btn = 4;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            btn = 5;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            btn = 6;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            btn = 9;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            btn = 10;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            btn = 11;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            btn = 12;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            btn = 13;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b14_Click(object sender, EventArgs e)
        {
            btn = 14;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b15_Click(object sender, EventArgs e)
        {
            btn = 15;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b16_Click(object sender, EventArgs e)
        {
            btn = 16;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b17_Click(object sender, EventArgs e)
        {
            btn = 17;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b18_Click(object sender, EventArgs e)
        {
            btn = 18;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b19_Click(object sender, EventArgs e)
        {
            btn = 19;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }

        private void b20_Click(object sender, EventArgs e)
        {
            btn = 20;

            MultiCheck newForm = new MultiCheck(this.btn);

            newForm.ShowDialog();
        }
    }
}
