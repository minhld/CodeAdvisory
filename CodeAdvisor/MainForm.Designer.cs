namespace CodeAdvisor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loadingProg = new System.Windows.Forms.ToolStripProgressBar();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.fileList = new System.Windows.Forms.ListView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.editorTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.consoleText = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.stackList = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lookupTSBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteTSBtn = new System.Windows.Forms.ToolStripButton();
            this.exitTSBtn = new System.Windows.Forms.ToolStripButton();
            this.loadFileTSBtn = new System.Windows.Forms.ToolStripButton();
            this.compileTSBtn = new System.Windows.Forms.ToolStripButton();
            this.comNRunTSBtn = new System.Windows.Forms.ToolStripButton();
            this.settingTSBtn = new System.Windows.Forms.ToolStripButton();
            this.aboutTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.editorTab.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitTSBtn,
            this.toolStripSeparator1,
            this.loadFileTSBtn,
            this.toolStripSeparator2,
            this.compileTSBtn,
            this.comNRunTSBtn,
            this.toolStripSeparator3,
            this.settingTSBtn,
            this.aboutTSBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadingProg,
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1164, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loadingProg
            // 
            this.loadingProg.Name = "loadingProg";
            this.loadingProg.Size = new System.Drawing.Size(200, 16);
            this.loadingProg.Visible = false;
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(72, 17);
            this.statusText.Text = "Compiling...";
            this.statusText.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1164, 664);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.fileList);
            this.splitContainer5.Size = new System.Drawing.Size(233, 664);
            this.splitContainer5.SplitterDistance = 328;
            this.splitContainer5.TabIndex = 0;
            // 
            // fileList
            // 
            this.fileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.Location = new System.Drawing.Point(0, 0);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(233, 328);
            this.fileList.TabIndex = 1;
            this.fileList.UseCompatibleStateImageBehavior = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(927, 664);
            this.splitContainer2.SplitterDistance = 536;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.editorTab);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.consoleText);
            this.splitContainer3.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer3.Size = new System.Drawing.Size(536, 664);
            this.splitContainer3.SplitterDistance = 442;
            this.splitContainer3.TabIndex = 0;
            // 
            // editorTab
            // 
            this.editorTab.Controls.Add(this.tabPage1);
            this.editorTab.Controls.Add(this.tabPage2);
            this.editorTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorTab.Location = new System.Drawing.Point(0, 0);
            this.editorTab.Name = "editorTab";
            this.editorTab.SelectedIndex = 0;
            this.editorTab.Size = new System.Drawing.Size(536, 442);
            this.editorTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(528, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(528, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // consoleText
            // 
            this.consoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleText.Location = new System.Drawing.Point(0, 25);
            this.consoleText.Name = "consoleText";
            this.consoleText.Size = new System.Drawing.Size(536, 193);
            this.consoleText.TabIndex = 1;
            this.consoleText.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookupTSBtn,
            this.toolStripSeparator4,
            this.deleteTSBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(536, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.stackList);
            this.splitContainer4.Size = new System.Drawing.Size(387, 664);
            this.splitContainer4.SplitterDistance = 311;
            this.splitContainer4.TabIndex = 0;
            // 
            // stackList
            // 
            this.stackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackList.Location = new System.Drawing.Point(0, 0);
            this.stackList.Name = "stackList";
            this.stackList.Size = new System.Drawing.Size(387, 311);
            this.stackList.TabIndex = 1;
            this.stackList.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Java files (*.java)|*.java|All files (*.*)|*.*";
            // 
            // lookupTSBtn
            // 
            this.lookupTSBtn.Image = global::CodeAdvisor.Properties.Resources.find;
            this.lookupTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lookupTSBtn.Name = "lookupTSBtn";
            this.lookupTSBtn.Size = new System.Drawing.Size(71, 22);
            this.lookupTSBtn.Text = "Look Up";
            this.lookupTSBtn.Click += new System.EventHandler(this.lookupTSBtn_Click);
            // 
            // deleteTSBtn
            // 
            this.deleteTSBtn.Image = global::CodeAdvisor.Properties.Resources.edit_clear;
            this.deleteTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTSBtn.Name = "deleteTSBtn";
            this.deleteTSBtn.Size = new System.Drawing.Size(54, 22);
            this.deleteTSBtn.Text = "Clear";
            this.deleteTSBtn.Click += new System.EventHandler(this.deleteTSBtn_Click);
            // 
            // exitTSBtn
            // 
            this.exitTSBtn.Image = global::CodeAdvisor.Properties.Resources.gnome_panel_force_quit;
            this.exitTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitTSBtn.Name = "exitTSBtn";
            this.exitTSBtn.Size = new System.Drawing.Size(45, 22);
            this.exitTSBtn.Text = "Exit";
            this.exitTSBtn.Click += new System.EventHandler(this.exitTSBtn_Click);
            // 
            // loadFileTSBtn
            // 
            this.loadFileTSBtn.Image = global::CodeAdvisor.Properties.Resources.generic_folder;
            this.loadFileTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadFileTSBtn.Name = "loadFileTSBtn";
            this.loadFileTSBtn.Size = new System.Drawing.Size(74, 22);
            this.loadFileTSBtn.Text = "Load File";
            this.loadFileTSBtn.Click += new System.EventHandler(this.loadFileTSBtn_Click);
            // 
            // compileTSBtn
            // 
            this.compileTSBtn.Image = global::CodeAdvisor.Properties.Resources.exec;
            this.compileTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compileTSBtn.Name = "compileTSBtn";
            this.compileTSBtn.Size = new System.Drawing.Size(72, 22);
            this.compileTSBtn.Text = "Compile";
            this.compileTSBtn.Click += new System.EventHandler(this.compileTSBtn_Click);
            // 
            // comNRunTSBtn
            // 
            this.comNRunTSBtn.Image = global::CodeAdvisor.Properties.Resources.documents_yellow_exec;
            this.comNRunTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.comNRunTSBtn.Name = "comNRunTSBtn";
            this.comNRunTSBtn.Size = new System.Drawing.Size(109, 22);
            this.comNRunTSBtn.Text = "Compile && Run";
            this.comNRunTSBtn.Click += new System.EventHandler(this.comNRunTSBtn_Click);
            // 
            // settingTSBtn
            // 
            this.settingTSBtn.Image = global::CodeAdvisor.Properties.Resources.advancedsettings;
            this.settingTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingTSBtn.Name = "settingTSBtn";
            this.settingTSBtn.Size = new System.Drawing.Size(69, 22);
            this.settingTSBtn.Text = "Settings";
            // 
            // aboutTSBtn
            // 
            this.aboutTSBtn.Image = global::CodeAdvisor.Properties.Resources.dialog_question;
            this.aboutTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutTSBtn.Name = "aboutTSBtn";
            this.aboutTSBtn.Size = new System.Drawing.Size(76, 22);
            this.aboutTSBtn.Text = "About Us";
            this.aboutTSBtn.Click += new System.EventHandler(this.aboutTSBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 711);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Code Avisor v1.0";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.editorTab.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exitTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton loadFileTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton compileTSBtn;
        private System.Windows.Forms.ToolStripButton comNRunTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton settingTSBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar loadingProg;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl editorTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox consoleText;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListView stackList;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ToolStripButton deleteTSBtn;
        private System.Windows.Forms.ToolStripButton lookupTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton aboutTSBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

