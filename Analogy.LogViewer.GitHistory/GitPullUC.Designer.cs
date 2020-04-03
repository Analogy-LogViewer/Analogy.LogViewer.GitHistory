namespace Analogy.LogViewer.GitHistory
{
    partial class GitPullUC
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
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chkbSavePassword = new System.Windows.Forms.CheckBox();
            this.lstRepositores = new System.Windows.Forms.ListBox();
            this.lblRepositories = new System.Windows.Forms.Label();
            this.BtnOperation = new System.Windows.Forms.Button();
            this.txtbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtbUser
            // 
            this.txtbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbUser.Location = new System.Drawing.Point(177, 3);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(679, 22);
            this.txtbUser.TabIndex = 16;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(8, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "User";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPassword.Location = new System.Drawing.Point(177, 31);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(679, 22);
            this.txtbPassword.TabIndex = 18;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 34);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password:";
            // 
            // chkbSavePassword
            // 
            this.chkbSavePassword.AutoSize = true;
            this.chkbSavePassword.Location = new System.Drawing.Point(177, 59);
            this.chkbSavePassword.Name = "chkbSavePassword";
            this.chkbSavePassword.Size = new System.Drawing.Size(228, 21);
            this.chkbSavePassword.TabIndex = 19;
            this.chkbSavePassword.Text = "Save Password (not encrypted)";
            this.chkbSavePassword.UseVisualStyleBackColor = true;
            // 
            // lstRepositores
            // 
            this.lstRepositores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRepositores.FormattingEnabled = true;
            this.lstRepositores.ItemHeight = 16;
            this.lstRepositores.Location = new System.Drawing.Point(177, 86);
            this.lstRepositores.Name = "lstRepositores";
            this.lstRepositores.Size = new System.Drawing.Size(679, 180);
            this.lstRepositores.TabIndex = 24;
            this.lstRepositores.SelectedValueChanged += new System.EventHandler(this.lstRepositores_SelectedValueChanged);
            // 
            // lblRepositories
            // 
            this.lblRepositories.AutoSize = true;
            this.lblRepositories.Location = new System.Drawing.Point(8, 86);
            this.lblRepositories.Name = "lblRepositories";
            this.lblRepositories.Size = new System.Drawing.Size(91, 17);
            this.lblRepositories.TabIndex = 25;
            this.lblRepositories.Text = "Repositories:";
            // 
            // BtnOperation
            // 
            this.BtnOperation.Location = new System.Drawing.Point(11, 272);
            this.BtnOperation.Name = "BtnOperation";
            this.BtnOperation.Size = new System.Drawing.Size(157, 30);
            this.BtnOperation.TabIndex = 26;
            this.BtnOperation.Text = "Fetch";
            this.BtnOperation.UseVisualStyleBackColor = true;
            this.BtnOperation.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // txtbResult
            // 
            this.txtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbResult.Location = new System.Drawing.Point(11, 308);
            this.txtbResult.Name = "txtbResult";
            this.txtbResult.Size = new System.Drawing.Size(845, 271);
            this.txtbResult.TabIndex = 27;
            this.txtbResult.Text = "";
            // 
            // GitPullUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbResult);
            this.Controls.Add(this.BtnOperation);
            this.Controls.Add(this.lblRepositories);
            this.Controls.Add(this.lstRepositores);
            this.Controls.Add(this.chkbSavePassword);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.lblUser);
            this.Name = "GitPullUC";
            this.Size = new System.Drawing.Size(859, 596);
            this.Load += new System.EventHandler(this.GitPullUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkbSavePassword;
        private System.Windows.Forms.ListBox lstRepositores;
        private System.Windows.Forms.Label lblRepositories;
        private System.Windows.Forms.Button BtnOperation;
        private System.Windows.Forms.RichTextBox txtbResult;
    }
}
