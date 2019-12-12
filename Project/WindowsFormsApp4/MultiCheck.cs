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
    public partial class MultiCheck : Form
    {
        int btn;

        public MultiCheck(int _btn)
        {
            InitializeComponent();
            btn = _btn;
        }

        private void MultiCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
