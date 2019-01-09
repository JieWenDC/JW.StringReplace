namespace JW.StringReplace
{
    partial class MatchList
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
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_lists = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lists)).BeginInit();
            this.SuspendLayout();
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "目录/文件";
            this.Path.Name = "Path";
            this.Path.Width = 800;
            // 
            // dgv_lists
            // 
            this.dgv_lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path});
            this.dgv_lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_lists.Location = new System.Drawing.Point(0, 0);
            this.dgv_lists.Name = "dgv_lists";
            this.dgv_lists.RowTemplate.Height = 23;
            this.dgv_lists.Size = new System.Drawing.Size(868, 521);
            this.dgv_lists.TabIndex = 1;
            // 
            // MatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 521);
            this.Controls.Add(this.dgv_lists);
            this.Name = "MatchList";
            this.Text = "MatchList";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridView dgv_lists;
    }
}