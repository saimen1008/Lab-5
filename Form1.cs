/*
Name- Saimen Preet Singh
ProjectName- TextEditorLab
Description- In this lab, we make a text editor with all basic functionality. We also add an AboutPage.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Adding text color
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
        // Adding background color
        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Black;
        }
        // New File
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        // Copy 
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text.ToString());
        }
        // Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
        // Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }
        // Adding Save dialog box
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Files (.txt)|*.txt";
            svf.Title = "Save file";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
            }
        }
        // Adding Open dialog box
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";
            ofd.Title = "Open a file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Files (.txt)|*.txt";
            svf.Title = "Save file";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
        // Undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        // About Page
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPage form = new AboutPage();
            form.ShowDialog();
        }
    }
}
