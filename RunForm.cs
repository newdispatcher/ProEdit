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

namespace UltraCoder
{
    public partial class RunForm : Form
    {
        public RunForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openprogram.Filter = "Executable Files(*.exe; *.bat; *.cmd; *.com; *.jar)|*.exe; *.bat;*.cmd;*.com;*.jar";
            if (openprogram.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openprogram.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(textBox1.Text);
        }
    }
}
