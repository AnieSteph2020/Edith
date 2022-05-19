using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Edith
{
    public partial class Edith : Form
    {
        public Edith()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void newFile(object sender, EventArgs e)
        {
            Process.Start("Edith.exe");
        }

        private void openFile(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            };
        }

        private void saveFile(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();

            if ( result == DialogResult.Cancel )
            {
                return ;
            }
        }

        private void txtCol(object sender, EventArgs e)
        { 
            DialogResult result = colorDialogTxt.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionColor = colorDialogTxt.Color; 
            }
            else richTextBox1.ForeColor = colorDialogTxt.Color;
        }

private void backCol(object sender, EventArgs e)
        {
            DialogResult result = colorDialogBack.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionBackColor = colorDialogBack.Color;
            }
            else richTextBox1.BackColor = colorDialogBack.Color;
        }

        private void fontDialog(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
            else richTextBox1.Font = fontDialog1.Font;

        }


        private void getHelpToolStripMenuGetHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=kFzViYkZAz4");
        }
    }
}
