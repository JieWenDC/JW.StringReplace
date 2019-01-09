namespace JW.StringReplace
{
    partial class MoveReplace
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
            this.txt_allowFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_allowFileExt = new System.Windows.Forms.TextBox();
            this.btn_move = new System.Windows.Forms.Button();
            this.txt_exLogs = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_logs = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txt_targetString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sourceString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.s = new System.Windows.Forms.Label();
            this.btn_sl_sourceDirectory = new System.Windows.Forms.Button();
            this.txt_sourcDdirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_excludeFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_excludeFileExt = new System.Windows.Forms.TextBox();
            this.btn_allMatchInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_targetDdirectory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "扩展名：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_allowFolder);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_allowFileExt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 83);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "仅查找容许的文件";
            // 
            // txt_allowFileExt
            // 
            this.txt_allowFileExt.Location = new System.Drawing.Point(93, 20);
            this.txt_allowFileExt.Name = "txt_allowFileExt";
            this.txt_allowFileExt.Size = new System.Drawing.Size(379, 21);
            this.txt_allowFileExt.TabIndex = 15;
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(105, 343);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(75, 23);
            this.btn_move.TabIndex = 27;
            this.btn_move.Text = "替换后移动";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 380);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 254);
            this.tabControl1.TabIndex = 26;
            // 
            // txt_targetString
            // 
            this.txt_targetString.Location = new System.Drawing.Point(90, 101);
            this.txt_targetString.Name = "txt_targetString";
            this.txt_targetString.Size = new System.Drawing.Size(379, 21);
            this.txt_targetString.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "目标字符：";
            // 
            // txt_sourceString
            // 
            this.txt_sourceString.Location = new System.Drawing.Point(90, 74);
            this.txt_sourceString.Name = "txt_sourceString";
            this.txt_sourceString.Size = new System.Drawing.Size(379, 21);
            this.txt_sourceString.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_targetDdirectory);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_targetString);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sourceString);
            this.groupBox1.Controls.Add(this.s);
            this.groupBox1.Controls.Add(this.btn_sl_sourceDirectory);
            this.groupBox1.Controls.Add(this.txt_sourcDdirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 139);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(15, 77);
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
            // 
            // txt_sourcDdirectory
            // 
            this.txt_sourcDdirectory.Location = new System.Drawing.Point(90, 20);
            this.txt_sourcDdirectory.Name = "txt_sourcDdirectory";
            this.txt_sourcDdirectory.Size = new System.Drawing.Size(379, 21);
            this.txt_sourcDdirectory.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "源目录：";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_excludeFolder);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_excludeFileExt);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(592, 83);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "";
            this.groupBox4.Text = "排除的文件";
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
            // btn_allMatchInfo
            // 
            this.btn_allMatchInfo.Location = new System.Drawing.Point(358, 343);
            this.btn_allMatchInfo.Name = "btn_allMatchInfo";
            this.btn_allMatchInfo.Size = new System.Drawing.Size(123, 23);
            this.btn_allMatchInfo.TabIndex = 24;
            this.btn_allMatchInfo.Text = "查看所有匹配";
            this.btn_allMatchInfo.UseVisualStyleBackColor = true;
            this.btn_allMatchInfo.Click += new System.EventHandler(this.btn_allMatchInfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "选择";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_targetDdirectory
            // 
            this.txt_targetDdirectory.Location = new System.Drawing.Point(90, 47);
            this.txt_targetDdirectory.Name = "txt_targetDdirectory";
            this.txt_targetDdirectory.Size = new System.Drawing.Size(379, 21);
            this.txt_targetDdirectory.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "目标目录：";
            // 
            // MoveReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 644);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_allMatchInfo);
            this.Name = "MoveReplace";
            this.Text = "MoveReplace";
            this.SizeChanged += new System.EventHandler(this.MoveReplace_SizeChanged);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_allowFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_allowFileExt;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.TextBox txt_exLogs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_logs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txt_targetString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sourceString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Button btn_sl_sourceDirectory;
        private System.Windows.Forms.TextBox txt_sourcDdirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_excludeFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_excludeFileExt;
        private System.Windows.Forms.Button btn_allMatchInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_targetDdirectory;
        private System.Windows.Forms.Label label7;
    }
}