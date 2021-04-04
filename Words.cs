using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_2
{
    public partial class Words : Form
    {
        public int i = 0;
        public Words()
        {
            InitializeComponent();
        }

        private void Words_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(i);
        }
    }
}
