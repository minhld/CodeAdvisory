using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeAdvisor.Supports;

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
                ListViewItem fileListItem = Utils.addFileItem(javaFile);
                if (fileListItem == null)
                {
                    MessageBox.Show(this, "this file was already added", Properties.Resources.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                fileListItem.ImageIndex = 0;
                fileList.Items.Add(fileListItem);
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
            MessageBox.Show(this, "this application is made by Minh & Daehyeok @ ASSL", Properties.Resources.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lookupTSBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteTSBtn_Click(object sender, EventArgs e)
        {

        }

        private void fileList_DoubleClick(object sender, EventArgs e)
        {
            string filePath = (string) fileList.SelectedItems[0].Tag;
            Utils.addTab(editorTab, filePath);
        }

        #endregion

        #region Context Menu Events

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileList_DoubleClick(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utils.removeTab(editorTab);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.removeAllTabs(editorTab);
        }

        #endregion


    }
}
