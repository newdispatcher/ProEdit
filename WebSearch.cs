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
    public partial class WebSearch : Form
    {
        

        public WebSearch()
        {
            InitializeComponent();
        }
        

        private void search_Click(object sender, EventArgs e)
        {
            if(google.Checked == true)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?q=" + textBox1.Text);
            }

            if (bing.Checked == true)
            {
                System.Diagnostics.Process.Start("http://www.bing.com/search?q=" + textBox1.Text);
            }
            if(wiki.Checked == true)
            {
                System.Diagnostics.Process.Start("http://hu.wikipedia.org/wiki/Special:Search?search=" + textBox1.Text);
            }
            if(stackoverflow.Checked == true)
            {
                System.Diagnostics.Process.Start("http://stackoverflow.com/questions/tagged/" + textBox1.Text);
            }
        }
    }
}
