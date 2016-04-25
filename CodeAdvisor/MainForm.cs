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
using System.Diagnostics;
using System.IO;

namespace CodeAdvisor
{
    public partial class MainForm : Form
    {
        #region Variables

        const int TAB_CONSOLE_IDX = 1;
        const int TAB_ERROR_IDX = 2;

        #endregion

        #region Entry

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            // temporarily set for testing only
            JavaUtils.ProcessDataAvailable += JavaUtils_ProcessDataAvailable;
            JavaUtils.ProcessErrorAvailable += JavaUtils_ProcessErrorAvailable;

            bool javaPathAvail = JavaUtils.initJavaUtils(Properties.Resources.JDK_PATH);
            if (!javaPathAvail)
            {
                MessageBox.Show(this, "JDK path is missing", Properties.Resources.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void JavaUtils_ProcessDataAvailable(object sender, EventArgs e)
        {
            DataReceivedEventArgs de = (DataReceivedEventArgs)e;
            if (de.Data == null || de.Data.Trim().Equals(string.Empty))
            {
                return;
            }

            this.BeginInvoke(new MethodInvoker(() =>
            {
                consoleText.AppendText(de.Data + "\n" ?? string.Empty);
                consoleTabs.SelectedIndex = TAB_CONSOLE_IDX;
            }));
        }

        private void JavaUtils_ProcessErrorAvailable(object sender, EventArgs e)
        {
            DataReceivedEventArgs de = (DataReceivedEventArgs)e;
            if (de.Data == null || de.Data.Trim().Equals(string.Empty))
            {
                return;
            }

            this.BeginInvoke(new MethodInvoker(() =>
            {
                errorText.AppendText(de.Data + "\n" ?? string.Empty);
                consoleTabs.SelectedIndex = TAB_ERROR_IDX;
            }));
        }

        private void exitTSBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "are you sure you want to quit?", Properties.Resources.APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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
                    MessageBox.Show(this, "this file was already added", Properties.Resources.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                fileListItem.ImageIndex = 0;
                fileList.Items.Add(fileListItem);
            }
        }

        private void compileTSBtn_Click(object sender, EventArgs e)
        {
            if (editorTab.SelectedTab == null)
            {
                MessageBox.Show(this, "please open a Java file to continue", Properties.Resources.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string javaFilePath = (string)editorTab.SelectedTab.Tag;
            consoleText.Text = string.Empty;
            errorText.Text = string.Empty;

            string javaClassPath = JavaUtils.compile(javaFilePath);
            if (File.Exists(javaClassPath))
            {
                printConsoleMessage("compiled successfully\n" + javaClassPath);
            }
            else
            {
                printErrorMessage("compiled failed\n");
            }
        }

        private void comNRunTSBtn_Click(object sender, EventArgs e)
        {
            if (editorTab.SelectedTab == null)
            {
                MessageBox.Show(this, "please open a Java file to continue", Properties.Resources.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string javaFilePath = (string)editorTab.SelectedTab.Tag;
            string javaClassPath = Utils.checkClassAvailable(javaFilePath);
            if (javaClassPath.Equals(""))
            {
                MessageBox.Show(this, "class file is not available. please recompile it", Properties.Resources.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consoleText.Text = string.Empty;
            errorText.Text = string.Empty;

            JavaUtils.execute(javaClassPath);
        }

        private void aboutTSBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "this application is made by Minh & Daehyeok @ ASSL", Properties.Resources.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lookupTSBtn_Click(object sender, EventArgs e)
        {
            string reqJson = ExceptionUtils.parseException(errorText.Text);
        }

        private void deleteTSBtn_Click(object sender, EventArgs e)
        {

        }

        private void fileList_DoubleClick(object sender, EventArgs e)
        {
            if (fileList.SelectedItems.Count > 0)
            {
                string filePath = (string)fileList.SelectedItems[0].Tag;
                Utils.addTab(editorTab, filePath);
            }
        }

        private void saveFileTSBtn_Click(object sender, EventArgs e)
        {
            if (editorTab.SelectedTab == null)
            {
                return;
            }
            string javaFilePath = (string)editorTab.SelectedTab.Tag;

            string editorText = Utils.getTextFromTab(javaFilePath);
            Utils.saveToFile(javaFilePath, editorText);
            statusText.Text = "saved!";
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

        #region Support Functions

        public void printConsoleMessage(string info)
        {
            consoleText.AppendText(info);
            consoleTabs.SelectedIndex = TAB_CONSOLE_IDX;
        }

        public void printErrorMessage(string error)
        {
            errorText.AppendText(error);
            consoleTabs.SelectedIndex = TAB_ERROR_IDX;
        }

        #endregion
     
    }
}
