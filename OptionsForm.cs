using FastColoredTextBoxNS;
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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }
        public EditForm edf = null;

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            MessageBox.Show("The settings to take effect, restart the program!", "Restart the program!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new HotkeysEditorForm(edf.EditBox.HotkeysMapping);
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    edf.EditBox.HotkeysMapping = form.GetHotkeys();
            }
            catch
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
