using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using SyntaxHighlighter;

namespace CodeAdvisor.Supports
{
    class Utils
    {
        static Dictionary<string, string> fileMap = new Dictionary<string, string>();
        static Dictionary<string, RichTextBox> editorMap = new Dictionary<string, RichTextBox>();

        public static String addFile(string filePath)
        {
            int lastOffs = filePath.LastIndexOf("\\");
            fileMap.Add(filePath, filePath);
            return filePath.Substring(lastOffs + 1);
        }

        public static ListViewItem addFileItem(string filePath)
        {
            if (fileMap.ContainsKey(filePath))
            {
                return null;
            }

            string fileName = addFile(filePath);
            ListViewItem fileItem = new ListViewItem(fileName);
            fileItem.Tag = filePath;
            return fileItem;
        }

        public async static void addTab(TabControl parent, string filePath)
        {
            // if tab already openned the file 
            if (editorMap.ContainsKey(filePath))
            {
                return;
            }

            // create new tab
            int lastOffs = filePath.LastIndexOf("\\");
            TabPage tabPage = new TabPage(filePath.Substring(lastOffs + 1));
            tabPage.Tag = filePath;

            SyntaxRichTextBox editor = new SyntaxRichTextBox();
            editor.Dock = DockStyle.Fill;
            editor.AcceptsTab = true;

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    String line = await sr.ReadToEndAsync();
                    editor.Text = line;
                }
            }
            catch (Exception e)
            {
                return;
            }

            // colorize the existing text
            editor.ProcessAllLines();

            editorMap.Add(filePath, editor);
            tabPage.Controls.Add(editor);
            parent.TabPages.Add(tabPage);
        }


        public static void removeTab(TabControl parent)
        {
            TabPage tabPage = parent.SelectedTab;
            string filePath = (string)tabPage.Tag;

            // remove from the tab page list
            editorMap.Remove(filePath);
            parent.TabPages.Remove(tabPage);
        }

        public static void removeAllTabs(TabControl parent)
        {
            editorMap.Clear();
            parent.TabPages.Clear();
        }

        public static string checkClassAvailable(string javaFilePath)
        {
            int offs = javaFilePath.LastIndexOf(".java");
            string javaClassPath = javaFilePath.Substring(0, offs) + ".class";
            return File.Exists(javaClassPath) ? javaClassPath : "";
        }

        public static string getTextFromTab(string fileAtTab)
        {
            RichTextBox editor = editorMap[fileAtTab];
            return editor.Text;
        }

        public static bool saveToFile(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
            return true;
        }
    }
}
