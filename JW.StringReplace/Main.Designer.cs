namespace JW.StringReplace
{
    partial class Main
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
            this.btn_allMatchInfo = new System.Windows.Forms.Button();
            this.txt_excludeFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_excludeFileExt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_replaceFileContent = new System.Windows.Forms.CheckBox();
            this.cb_replaceFile = new System.Windows.Forms.CheckBox();
            this.cb_replaceFolder = new System.Windows.Forms.CheckBox();
            this.txt_sourcDdirectory = new System.Windows.Forms.TextBox();
            this.txt_targetString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sourceString = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.Label();
            this.btn_sl_sourceDirectory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_replace = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_logs = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_exLogs = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_allowFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_allowFileExt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_allMatchInfo
            // 
            this.btn_allMatchInfo.Location = new System.Drawing.Point(346, 396);
            this.btn_allMatchInfo.Name = "btn_allMatchInfo";
            this.btn_allMatchInfo.Size = new System.Drawing.Size(123, 23);
            this.btn_allMatchInfo.TabIndex = 17;
            this.btn_allMatchInfo.Text = "查看所有匹配";
            this.btn_allMatchInfo.UseVisualStyleBackColor = true;
            this.btn_allMatchInfo.Click += new System.EventHandler(this.btn_allMatchInfo_Click);
            // 
            // txt_excludeFolder
            // 
            this.txt_excludeFolder.Location = new System.Drawing.Point(93, 47);
            this.txt_excludeFolder.Name = "txt_excludeFolder";
            this.txt_excludeFolder.Size = new System.Drawing.Size(379, 21);
            this.txt_excludeFolder.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "文件夹：";
            // 
            // txt_excludeFileExt
            // 
            this.txt_excludeFileExt.Location = new System.Drawing.Point(93, 20);
            this.txt_excludeFileExt.Name = "txt_excludeFileExt";
            this.txt_excludeFileExt.Size = new System.Drawing.Size(379, 21);
            this.txt_excludeFileExt.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_excludeFolder);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_excludeFileExt);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(592, 83);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "";
            this.groupBox4.Text = "排除的文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "扩展名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_replaceFileContent);
            this.groupBox2.Controls.Add(this.cb_replaceFile);
            this.groupBox2.Controls.Add(this.cb_replaceFolder);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 49);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // cb_replaceFileContent
            // 
            this.cb_replaceFileContent.AutoSize = true;
            this.cb_replaceFileContent.Checked = true;
            this.cb_replaceFileContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_replaceFileContent.Location = new System.Drawing.Point(319, 20);
            this.cb_replaceFileContent.Name = "cb_replaceFileContent";
            this.cb_replaceFileContent.Size = new System.Drawing.Size(96, 16);
            this.cb_replaceFileContent.TabIndex = 2;
            this.cb_replaceFileContent.Text = "替换文件内容";
            this.cb_replaceFileContent.UseVisualStyleBackColor = true;
            // 
            // cb_replaceFile
            // 
            this.cb_replaceFile.AutoSize = true;
            this.cb_replaceFile.Checked = true;
            this.cb_replaceFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_replaceFile.Location = new System.Drawing.Point(204, 20);
            this.cb_replaceFile.Name = "cb_replaceFile";
            this.cb_replaceFile.Size = new System.Drawing.Size(84, 16);
            this.cb_replaceFile.TabIndex = 1;
            this.cb_replaceFile.Text = "替换文件名";
            this.cb_replaceFile.UseVisualStyleBackColor = true;
            // 
            // cb_replaceFolder
            // 
            this.cb_replaceFolder.AutoSize = true;
            this.cb_replaceFolder.Checked = true;
            this.cb_replaceFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_replaceFolder.Location = new System.Drawing.Point(81, 20);
            this.cb_replaceFolder.Name = "cb_replaceFolder";
            this.cb_replaceFolder.Size = new System.Drawing.Size(108, 16);
            this.cb_replaceFolder.TabIndex = 0;
            this.cb_replaceFolder.Text = "替换文件夹名称";
            this.cb_replaceFolder.UseVisualStyleBackColor = true;
            // 
            // txt_sourcDdirectory
            // 
            this.txt_sourcDdirectory.Location = new System.Drawing.Point(90, 20);
            this.txt_sourcDdirectory.Name = "txt_sourcDdirectory";
            this.txt_sourcDdirectory.Size = new System.Drawing.Size(379, 21);
            this.txt_sourcDdirectory.TabIndex = 8;
            // 
            // txt_targetString
            // 
            this.txt_targetString.Location = new System.Drawing.Point(90, 74);
            this.txt_targetString.Name = "txt_targetString";
            this.txt_targetString.Size = new System.Drawing.Size(379, 21);
            this.txt_targetString.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "目标字符：";
            // 
            // txt_sourceString
            // 
            this.txt_sourceString.Location = new System.Drawing.Point(90, 47);
            this.txt_sourceString.Name = "txt_sourceString";
            this.txt_sourceString.Size = new System.Drawing.Size(379, 21);
            this.txt_sourceString.TabIndex = 11;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(27, 50);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(53, 12);
            this.s.TabIndex = 10;
            this.s.Text = "源字符：";
            // 
            // btn_sl_sourceDirectory
            // 
            this.btn_sl_sourceDirectory.Location = new System.Drawing.Point(495, 18);
            this.btn_sl_sourceDirectory.Name = "btn_sl_sourceDirectory";
            this.btn_sl_sourceDirectory.Size = new System.Drawing.Size(75, 23);
            this.btn_sl_sourceDirectory.TabIndex = 9;
            this.btn_sl_sourceDirectory.Text = "选择";
            this.btn_sl_sourceDirectory.UseVisualStyleBackColor = true;
            this.btn_sl_sourceDirectory.Click += new System.EventHandler(this.btn_sl_sourceDirectory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_targetString);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sourceString);
            this.groupBox1.Controls.Add(this.s);
            this.groupBox1.Controls.Add(this.btn_sl_sourceDirectory);
            this.groupBox1.Controls.Add(this.txt_sourcDdirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 115);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "目录：";
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(105, 396);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(75, 23);
            this.btn_replace.TabIndex = 12;
            this.btn_replace.Text = "替换";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 425);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 254);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_logs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "日志";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_logs
            // 
            this.txt_logs.Location = new System.Drawing.Point(6, 6);
            this.txt_logs.Multiline = true;
            this.txt_logs.Name = "txt_logs";
            this.txt_logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_logs.Size = new System.Drawing.Size(575, 216);
            this.txt_logs.TabIndex = 1;
            this.txt_logs.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_exLogs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "异常日志";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_exLogs
            // 
            this.txt_exLogs.Location = new System.Drawing.Point(6, 6);
            this.txt_exLogs.Multiline = true;
            this.txt_exLogs.Name = "txt_exLogs";
            this.txt_exLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_exLogs.Size = new System.Drawing.Size(575, 216);
            this.txt_exLogs.TabIndex = 2;
            this.txt_exLogs.WordWrap = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_allowFolder);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_allowFileExt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(12, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 83);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "仅查找容许的文件";
            // 
            // txt_allowFolder
            // 
            this.txt_allowFolder.Location = new System.Drawing.Point(93, 47);
            this.txt_allowFolder.Name = "txt_allowFolder";
            this.txt_allowFolder.Size = new System.Drawing.Size(379, 21);
            this.txt_allowFolder.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "文件夹：";
            // 
            // txt_allowFileExt
            // 
            this.txt_allowFileExt.Location = new System.Drawing.Point(93, 20);
            this.txt_allowFileExt.Name = "txt_allowFileExt";
            this.txt_allowFileExt.Size = new System.Drawing.Size(379, 21);
            this.txt_allowFileExt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "扩展名：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "移动并替换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_allMatchInfo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_replace);
            this.Name = "Main";
            this.Text = "Main";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_allMatchInfo;
        private System.Windows.Forms.TextBox txt_excludeFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_excludeFileExt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_replaceFileContent;
        private System.Windows.Forms.CheckBox cb_replaceFile;
        private System.Windows.Forms.CheckBox cb_replaceFolder;
        private System.Windows.Forms.TextBox txt_sourcDdirectory;
        private System.Windows.Forms.TextBox txt_targetString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sourceString;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Button btn_sl_sourceDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_logs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_exLogs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_allowFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_allowFileExt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}