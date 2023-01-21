namespace Analogy.LogViewer.GitHistory
{
    partial class GitRepositoriesSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRepository = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.rbCount = new System.Windows.Forms.RadioButton();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.nudCommits = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lstRepositores = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTags = new System.Windows.Forms.NumericUpDown();
            this.lblCommitsCount = new System.Windows.Forms.Label();
            this.lblTagsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTags)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRepository
            // 
            this.txtRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepository.Location = new System.Drawing.Point(191, 3);
            this.txtRepository.Name = "txtRepository";
            this.txtRepository.Size = new System.Drawing.Size(341, 26);
            this.txtRepository.TabIndex = 14;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(22, 6);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(160, 18);
            this.lblPath.TabIndex = 13;
            this.lblPath.Text = "Repository Path on disk";
            // 
            // rbCount
            // 
            this.rbCount.AutoSize = true;
            this.rbCount.Checked = true;
            this.rbCount.Location = new System.Drawing.Point(25, 35);
            this.rbCount.Name = "rbCount";
            this.rbCount.Size = new System.Drawing.Size(116, 22);
            this.rbCount.TabIndex = 19;
            this.rbCount.TabStop = true;
            this.rbCount.Text = "Items to pull:";
            this.rbCount.UseVisualStyleBackColor = true;
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Location = new System.Drawing.Point(25, 104);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(160, 22);
            this.rbDate.TabIndex = 20;
            this.rbDate.Text = "Up to date to fetch:";
            this.rbDate.UseVisualStyleBackColor = true;
            // 
            // nudCommits
            // 
            this.nudCommits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCommits.Location = new System.Drawing.Point(353, 37);
            this.nudCommits.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCommits.Name = "nudCommits";
            this.nudCommits.Size = new System.Drawing.Size(228, 26);
            this.nudCommits.TabIndex = 21;
            this.nudCommits.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(390, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // lstRepositores
            // 
            this.lstRepositores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRepositores.FormattingEnabled = true;
            this.lstRepositores.ItemHeight = 18;
            this.lstRepositores.Location = new System.Drawing.Point(11, 144);
            this.lstRepositores.Name = "lstRepositores";
            this.lstRepositores.Size = new System.Drawing.Size(598, 202);
            this.lstRepositores.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(598, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 44);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.Location = new System.Drawing.Point(534, 3);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(47, 26);
            this.btnBrowser.TabIndex = 25;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Image = global::Analogy.LogViewer.GitHistory.Properties.Resources.Delete_16x16;
            this.BtnDelete.Location = new System.Drawing.Point(615, 144);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(43, 34);
            this.BtnDelete.TabIndex = 26;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 79);
            this.label1.TabIndex = 27;
            this.label1.Text = "for changes to take effect (when adding/removing repository) please restart the a" +
    "pplication";
            // 
            // nudTags
            // 
            this.nudTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTags.Location = new System.Drawing.Point(353, 72);
            this.nudTags.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTags.Name = "nudTags";
            this.nudTags.Size = new System.Drawing.Size(228, 26);
            this.nudTags.TabIndex = 29;
            this.nudTags.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblCommitsCount
            // 
            this.lblCommitsCount.AutoSize = true;
            this.lblCommitsCount.Location = new System.Drawing.Point(277, 39);
            this.lblCommitsCount.Name = "lblCommitsCount";
            this.lblCommitsCount.Size = new System.Drawing.Size(70, 18);
            this.lblCommitsCount.TabIndex = 30;
            this.lblCommitsCount.Text = "Commits:";
            // 
            // lblTagsCount
            // 
            this.lblTagsCount.AutoSize = true;
            this.lblTagsCount.Location = new System.Drawing.Point(277, 74);
            this.lblTagsCount.Name = "lblTagsCount";
            this.lblTagsCount.Size = new System.Drawing.Size(46, 18);
            this.lblTagsCount.TabIndex = 31;
            this.lblTagsCount.Text = "Tags:";
            // 
            // GitRepositoriesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTagsCount);
            this.Controls.Add(this.lblCommitsCount);
            this.Controls.Add(this.nudTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstRepositores);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nudCommits);
            this.Controls.Add(this.rbDate);
            this.Controls.Add(this.rbCount);
            this.Controls.Add(this.txtRepository);
            this.Controls.Add(this.lblPath);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "GitRepositoriesSettings";
            this.Size = new System.Drawing.Size(676, 428);
            this.Load += new System.EventHandler(this.GitRepositoriesSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCommits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepository;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.RadioButton rbCount;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.NumericUpDown nudCommits;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lstRepositores;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTags;
        private System.Windows.Forms.Label lblCommitsCount;
        private System.Windows.Forms.Label lblTagsCount;
    }
}
