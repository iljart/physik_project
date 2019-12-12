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

    public partial class Form2 : Form
    {
        int btn;
        int answer;
        int correct;//глобальный прав. ответ


        public Form2(int _btn)
        {
            InitializeComponent();
             btn = _btn;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            answer = -1;
            

            if (btn == 1)
            {
                textBox1.Text = "1 вопрос";
                v1.Text = "1 ваиант";
                v2.Text = "2 ваиант";
                v3.Text = "3 ваиант";
                correct = 3;

                //Form1.Score += 1;
             
                //MessageBox.Show(Convert.ToString(Form1.Score));
            }
            if (btn == 2)
            {
                textBox1.Text = "2 вопрос";
                v1.Text = "Q ваиант";
                v2.Text = "W ваиант";
                v3.Text = "E ваиант";
                correct = 2;

                //Form1.Score += 1;

                //MessageBox.Show(Convert.ToString(Form1.Score));
            }
        }

        private void v1_CheckedChanged(object sender, EventArgs e)
        {
            answer = 1;
        }

        private void v2_CheckedChanged(object sender, EventArgs e)
        {
            answer = 2;
        }

        private void v3_CheckedChanged(object sender, EventArgs e)
        {
            answer = 3;
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            if (correct == answer)
            {
                
                Form1.Score += 1;

                MessageBox.Show("True");
               // Form2.close();
                //Form1.show();
                this.Close();

            }
            else
            {
               MessageBox.Show("False");
            }
        }
    }
}
