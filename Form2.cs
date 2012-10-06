using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sharParse
{
    public partial class set_partialMatches : Form
    {
        public static ToolStripMenuItem buffer_mnuItem = new ToolStripMenuItem();

        public set_partialMatches()
        {
            InitializeComponent();
            cb_enablePartialMatches.Checked = buffer_mnuItem.Checked;
        }

        private void cb_enablePartialMatches_CheckedChanged(object sender, EventArgs e)
        {
            buffer_mnuItem.Checked = cb_enablePartialMatches.Checked;
        }
    }
}
