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
    public partial class LetterForm : Form
    {
        public string text = "";
        public LetterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!((e.KeyChar > 64 && e.KeyChar < 91)||(e.KeyChar > 96 && e.KeyChar < 123)) && e.KeyChar != 8)
                e.Handled = true;
            else if (e.KeyChar != 8 && textBox1.Text.Length == 1)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            foreach(char c in text)
            {
                if (Convert.ToString(c) == textBox1.Text)
                    n++;
            }
            Words WForm = new Words();
            WForm.i = n;
            WForm.ShowDialog();
        }
    }
}
