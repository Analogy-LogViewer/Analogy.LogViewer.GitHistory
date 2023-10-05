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
            txtRepository = new System.Windows.Forms.TextBox();
            lblPath = new System.Windows.Forms.Label();
            rbCount = new System.Windows.Forms.RadioButton();
            rbDate = new System.Windows.Forms.RadioButton();
            nudCommits = new System.Windows.Forms.NumericUpDown();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            lstRepositores = new System.Windows.Forms.ListBox();
            btnAdd = new System.Windows.Forms.Button();
            btnBrowser = new System.Windows.Forms.Button();
            BtnDelete = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            nudTags = new System.Windows.Forms.NumericUpDown();
            lblCommitsCount = new System.Windows.Forms.Label();
            lblTagsCount = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudCommits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTags).BeginInit();
            SuspendLayout();
            // 
            // txtRepository
            // 
            txtRepository.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtRepository.Location = new System.Drawing.Point(191, 3);
            txtRepository.Name = "txtRepository";
            txtRepository.Size = new System.Drawing.Size(341, 26);
            txtRepository.TabIndex = 14;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new System.Drawing.Point(22, 6);
            lblPath.Name = "lblPath";
            lblPath.Size = new System.Drawing.Size(160, 18);
            lblPath.TabIndex = 13;
            lblPath.Text = "Repository Path on disk";
            // 
            // rbCount
            // 
            rbCount.AutoSize = true;
            rbCount.Checked = true;
            rbCount.Location = new System.Drawing.Point(25, 35);
            rbCount.Name = "rbCount";
            rbCount.Size = new System.Drawing.Size(116, 22);
            rbCount.TabIndex = 19;
            rbCount.TabStop = true;
            rbCount.Text = "Items to pull:";
            rbCount.UseVisualStyleBackColor = true;
            // 
            // rbDate
            // 
            rbDate.AutoSize = true;
            rbDate.Location = new System.Drawing.Point(25, 104);
            rbDate.Name = "rbDate";
            rbDate.Size = new System.Drawing.Size(160, 22);
            rbDate.TabIndex = 20;
            rbDate.Text = "Up to date to fetch:";
            rbDate.UseVisualStyleBackColor = true;
            // 
            // nudCommits
            // 
            nudCommits.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nudCommits.Location = new System.Drawing.Point(353, 37);
            nudCommits.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCommits.Name = "nudCommits";
            nudCommits.Size = new System.Drawing.Size(228, 26);
            nudCommits.TabIndex = 21;
            nudCommits.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dateTimePicker1.Location = new System.Drawing.Point(191, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(390, 26);
            dateTimePicker1.TabIndex = 22;
            // 
            // lstRepositores
            // 
            lstRepositores.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstRepositores.FormattingEnabled = true;
            lstRepositores.ItemHeight = 18;
            lstRepositores.Location = new System.Drawing.Point(11, 144);
            lstRepositores.Name = "lstRepositores";
            lstRepositores.Size = new System.Drawing.Size(598, 184);
            lstRepositores.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAdd.Location = new System.Drawing.Point(598, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 44);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBrowser
            // 
            btnBrowser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBrowser.Location = new System.Drawing.Point(534, 3);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Size = new System.Drawing.Size(47, 26);
            btnBrowser.TabIndex = 25;
            btnBrowser.Text = "...";
            btnBrowser.UseVisualStyleBackColor = true;
            btnBrowser.Click += btnBrowser_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.Delete_16x16;
            BtnDelete.Location = new System.Drawing.Point(615, 144);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new System.Drawing.Size(43, 34);
            BtnDelete.TabIndex = 26;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(8, 331);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(665, 50);
            label1.TabIndex = 27;
            label1.Text = "for changes to take effect (when adding/removing repository) please restart the application";
            // 
            // nudTags
            // 
            nudTags.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nudTags.Location = new System.Drawing.Point(353, 72);
            nudTags.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudTags.Name = "nudTags";
            nudTags.Size = new System.Drawing.Size(228, 26);
            nudTags.TabIndex = 29;
            nudTags.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblCommitsCount
            // 
            lblCommitsCount.AutoSize = true;
            lblCommitsCount.Location = new System.Drawing.Point(277, 39);
            lblCommitsCount.Name = "lblCommitsCount";
            lblCommitsCount.Size = new System.Drawing.Size(70, 18);
            lblCommitsCount.TabIndex = 30;
            lblCommitsCount.Text = "Commits:";
            // 
            // lblTagsCount
            // 
            lblTagsCount.AutoSize = true;
            lblTagsCount.Location = new System.Drawing.Point(277, 74);
            lblTagsCount.Name = "lblTagsCount";
            lblTagsCount.Size = new System.Drawing.Size(46, 18);
            lblTagsCount.TabIndex = 31;
            lblTagsCount.Text = "Tags:";
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Location = new System.Drawing.Point(598, 385);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 44);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // GitRepositoriesSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(lblTagsCount);
            Controls.Add(lblCommitsCount);
            Controls.Add(nudTags);
            Controls.Add(label1);
            Controls.Add(BtnDelete);
            Controls.Add(btnBrowser);
            Controls.Add(btnAdd);
            Controls.Add(lstRepositores);
            Controls.Add(dateTimePicker1);
            Controls.Add(nudCommits);
            Controls.Add(rbDate);
            Controls.Add(rbCount);
            Controls.Add(txtRepository);
            Controls.Add(lblPath);
            Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "GitRepositoriesSettings";
            Size = new System.Drawing.Size(676, 432);
            Load += GitRepositoriesSettings_Load;
            ((System.ComponentModel.ISupportInitialize)nudCommits).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTags).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button btnSave;
    }
}
