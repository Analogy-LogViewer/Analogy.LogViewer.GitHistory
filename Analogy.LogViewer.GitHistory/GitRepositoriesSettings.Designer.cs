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
            ((System.ComponentModel.ISupportInitialize)(this.nudCommits)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRepository
            // 
            this.txtRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepository.Location = new System.Drawing.Point(191, 3);
            this.txtRepository.Name = "txtRepository";
            this.txtRepository.Size = new System.Drawing.Size(407, 22);
            this.txtRepository.TabIndex = 14;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(22, 5);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(158, 17);
            this.lblPath.TabIndex = 13;
            this.lblPath.Text = "Repository Path on disk";
            // 
            // rbCount
            // 
            this.rbCount.AutoSize = true;
            this.rbCount.Checked = true;
            this.rbCount.Location = new System.Drawing.Point(25, 31);
            this.rbCount.Name = "rbCount";
            this.rbCount.Size = new System.Drawing.Size(130, 21);
            this.rbCount.TabIndex = 19;
            this.rbCount.Text = "Commit to fetch:";
            this.rbCount.UseVisualStyleBackColor = true;
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Location = new System.Drawing.Point(25, 63);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(150, 21);
            this.rbDate.TabIndex = 20;
            this.rbDate.Text = "Up to date to fetch:";
            this.rbDate.UseVisualStyleBackColor = true;
            // 
            // nudCommits
            // 
            this.nudCommits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCommits.Location = new System.Drawing.Point(191, 33);
            this.nudCommits.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCommits.Name = "nudCommits";
            this.nudCommits.Size = new System.Drawing.Size(407, 22);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(407, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // lstRepositores
            // 
            this.lstRepositores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRepositores.FormattingEnabled = true;
            this.lstRepositores.ItemHeight = 16;
            this.lstRepositores.Location = new System.Drawing.Point(11, 128);
            this.lstRepositores.Name = "lstRepositores";
            this.lstRepositores.Size = new System.Drawing.Size(615, 212);
            this.lstRepositores.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(615, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GitRepositoriesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstRepositores);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nudCommits);
            this.Controls.Add(this.rbDate);
            this.Controls.Add(this.rbCount);
            this.Controls.Add(this.txtRepository);
            this.Controls.Add(this.lblPath);
            this.Name = "GitRepositoriesSettings";
            this.Size = new System.Drawing.Size(693, 349);
            this.Load += new System.EventHandler(this.GitRepositoriesSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCommits)).EndInit();
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
    }
}
