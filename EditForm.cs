using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEdit
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();

            string theme = Properties.Settings.Default.theme;
            if(theme == "default")
            {
                EditBox.BackColor = Color.White;
                EditBox.IndentBackColor = Color.WhiteSmoke;
            }
            else if(theme == "yellow")
            {
                EditBox.BackColor = Color.Gold;
                EditBox.IndentBackColor = Color.Orange;
            }
            else if(theme == "dark")
            {
                EditBox.BackColor = Color.Black;
                EditBox.IndentBackColor = Color.DarkBlue;
                EditBox.ForeColor = Color.White;
            }
            else if(theme == "green")
            {
                EditBox.BackColor = Color.Green;
                EditBox.IndentBackColor = Color.Teal;
                EditBox.LineNumberColor = Color.White;
            }
            else if (theme == "choco")
            {
                EditBox.BackColor = Color.SaddleBrown;
                EditBox.IndentBackColor = Color.Brown;
                EditBox.LineNumberColor = Color.White;
            }
            else
            {
                EditBox.BackColor = Color.White;
                EditBox.IndentBackColor = Color.WhiteSmoke;
            }
                
        }
        public string actualfilename = "";
        public bool writeinfo = true;

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.Redo();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.Copy();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.SelectAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.ShowReplaceDialog();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.ShowGoToDialog();
        }

        private void commentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.InsertLinePrefix(EditBox.CommentPrefix);
        }

        private void uncommentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBox.RemoveLinePrefix(EditBox.CommentPrefix);
        }
    }
}
