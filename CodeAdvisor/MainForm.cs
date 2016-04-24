using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAdvisor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void exitTSBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadFileTSBtn_Click(object sender, EventArgs e)
        {
            DialogResult dRes = openFileDialog1.ShowDialog(this);
            if (dRes == DialogResult.OK)
            {
                String javaFile = openFileDialog1.FileName;
            }
        }

        private void compileTSBtn_Click(object sender, EventArgs e)
        {

        }

        private void comNRunTSBtn_Click(object sender, EventArgs e)
        {

        }

        private void aboutTSBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "This application is made by Minh & Daehyeok @ ASSL USU", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lookupTSBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteTSBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
