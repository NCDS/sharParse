using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Timers;

namespace sharParse
{

    public partial class sharParse : Form
    {
        string cDir;
        string sTxt;
        string rTxt;
        bool parse;
        System.IO.StreamReader fileStream;
        System.IO.StreamWriter writeStream;
        private System.Timers.Timer Time;

        //Work around for case insensitive comparisons
        public static bool Contains(string src, string cmp, StringComparison method)
        {
            return src.IndexOf(cmp, method) >= 0;
        }
        //

        // Author: Huisheng Chen, Architect www.xnlab.com
        public static string ReplaceEx(string original,
                    string pattern, string replacement)
        {
            int count, position0, position1;
            count = position0 = position1 = 0;
            string upperString = original.ToUpper();
            string upperPattern = pattern.ToUpper();
            int inc = (original.Length / pattern.Length) *
                      (replacement.Length - pattern.Length);
            char[] chars = new char[original.Length + Math.Max(0, inc)];
            while ((position1 = upperString.IndexOf(upperPattern,
                                              position0)) != -1)
            {
                for (int i = position0; i < position1; ++i)
                    chars[count++] = original[i];
                for (int i = 0; i < replacement.Length; ++i)
                    chars[count++] = replacement[i];
                position0 = position1 + pattern.Length;
            }
            if (position0 == 0) return original;
            for (int i = position0; i < original.Length; ++i)
                chars[count++] = original[i];
            return new string(chars, 0, count);
        }
        //

        public sharParse()
        {
            cDir = "c:/";
            InitializeComponent();
            tb_fileDirectory.Text = cDir;
        }
        //

        public bool parseFile()
        {
            int i;

            try
            {
                // Read file and save to 'txt'
                fileStream = new System.IO.StreamReader(cDir);
                string txt = fileStream.ReadToEnd();
                fileStream.Close();

                // Case sensitivity implementation
                if (!caseSensitiveToolStripMenuItem.Checked)
                {
                    if (!Contains(txt, sTxt, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("No matches found for '" + sTxt + "'.\n Please ensure your settings match your Search Text respectively.", "Error: No Matches Found!");
                        return (false);
                    }
                    else
                        txt = ReplaceEx(txt, sTxt, rTxt);
                }
                else
                {
                    if (!txt.Contains(sTxt))
                    {
                        MessageBox.Show("No matches found for '" + sTxt + "'.\n Please ensure your settings match your Search Text respectively.", "Error: No Matches Found!");
                        return (false);
                    }
                    else
                        txt = txt.Replace(sTxt, rTxt);
                }

                // Commit changes back to file
                writeStream = new System.IO.StreamWriter(cDir);
                writeStream.Write(txt);
               // writeStream.Close();

                return (true);
            }
            catch
            {
                return (false);
            }
            finally
            {
                fileStream.Close();
                writeStream.Close();

                // To check against 'Time' for progressBar
                parse = true;
                
            }
        }
        //

        private void btn_browse_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    if (!openFileDialog1.CheckFileExists) //Verify respective file exists
                    {
                        if (MessageBox.Show("File not found at specified directory, try again?", "Error locating file!", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else
                    {
                        cDir = openFileDialog1.FileName; // Store selected path to var 'cDir'
                        tb_fileDirectory.Text = cDir;
                        return;
                    }
                }
            }
        }
        //

        private void tb_fileDirectory_TextChanged(object sender, EventArgs e)
        {
            cDir = tb_fileDirectory.Text;
        }
        //

        private void tb_fileDirectory_Leave(object sender, EventArgs e)
        {
            cDir = tb_fileDirectory.Text;
        }
        //

        private void tb_fileDirectory_DoubleClick(object sender, EventArgs e)
        {
            tb_fileDirectory.SelectAll();
        }
        //

        private void tb_searchText_Leave(object sender, EventArgs e)
        {
            sTxt = tb_searchText.Text;
        }
        //

        private void tb_replaceText_Leave(object sender, EventArgs e)
        {
            rTxt = tb_replaceText.Text;
        }
        //

        private void btn_parse_Click(object sender, EventArgs e)
        {
            if (!parseFile())
            {
                MessageBox.Show("Unable to parse file @ " + cDir, "Error!");
            }
        }
        //

        private void partialMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set_partialMatches partialMatchSettings = new set_partialMatches();
            partialMatchSettings.ShowDialog();
            partialMatchesToolStripMenuItem.Checked = set_partialMatches.buffer_mnuItem.Checked;
        }
        //

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //

        private void tb_searchText_TextChanged(object sender, EventArgs e)
        {

        }
        //

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // To ensure the progress bar has adequate time to display progress before execution is complete.
            prog_Timer.Enabled = true;
            prog_Timer.Interval = 2000;
            
            // Init progress bar 'process'
            progressBar1.Style = ProgressBarStyle.Marquee;

            if (!parseFile())
            {
                MessageBox.Show("Unable to parse file @ " + cDir, "Error!");
            }
            
        }
        //

        private void prog_Timer_Tick(object sender, EventArgs e)
        {
            if (parse)
            {
                prog_Timer.Enabled = false;
                progressBar1.Style = ProgressBarStyle.Blocks;
            }
        }
    }
}
