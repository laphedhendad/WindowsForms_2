using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms_2
{
    public partial class Form1 : Form
    {
        private bool fileIs = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void загрузитьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileIs = true;
        }

        private void количествоСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileIs)
            {
                using (FileStream fs = File.OpenRead(openFileDialog1.FileName))
                {
                    byte[] array = new byte[fs.Length];
                    fs.Read(array, 0, array.Length);
                    string text = Encoding.Default.GetString(array);
                    string[] wordArr = text.Split(' ');
                    Words WForm = new Words();
                    WForm.i = wordArr.Length;
                    WForm.ShowDialog();
                }
            }
            else
            {
                ErrorForm EForm = new ErrorForm();
                EForm.ShowDialog();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void повторяемостьБуквыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileIs)
            {
                LetterForm LForm = new LetterForm();
                using (FileStream fs = File.OpenRead(openFileDialog1.FileName))
                {
                    byte[] array = new byte[fs.Length];
                    fs.Read(array, 0, array.Length);
                    string text = Encoding.Default.GetString(array);
                    LForm.text = text;
                }
                LForm.ShowDialog();
            }
            else
            {
                ErrorForm EForm = new ErrorForm();
                EForm.ShowDialog();
            }
        }
    }
}
