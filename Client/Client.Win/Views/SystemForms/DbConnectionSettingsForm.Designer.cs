namespace Client.Win.Views.SystemForms
{
    partial class DbConnectionSettingsForm
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
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.WaitingProgressBar = new System.Windows.Forms.ProgressBar();
            this.CanselButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.DataSourceTextBox = new System.Windows.Forms.TextBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DataBaseTextBox = new System.Windows.Forms.TextBox();
            this.DataSourceLable = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.DataBaseLable = new System.Windows.Forms.Label();
            this.UserIdCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonsPanel.Controls.Add(this.WaitingProgressBar);
            this.ButtonsPanel.Controls.Add(this.CanselButton);
            this.ButtonsPanel.Controls.Add(this.AcceptButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 116);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(488, 34);
            this.ButtonsPanel.TabIndex = 8;
            // 
            // WaitingProgressBar
            // 
            this.WaitingProgressBar.Location = new System.Drawing.Point(174, 4);
            this.WaitingProgressBar.Name = "WaitingProgressBar";
            this.WaitingProgressBar.Size = new System.Drawing.Size(301, 23);
            this.WaitingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.WaitingProgressBar.TabIndex = 2;
            this.WaitingProgressBar.Visible = false;
            this.WaitingProgressBar.Click += new System.EventHandler(this.WaitingProgressBar_Click);
            // 
            // CanselButton
            // 
            this.CanselButton.Location = new System.Drawing.Point(93, 4);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(75, 23);
            this.CanselButton.TabIndex = 1;
            this.CanselButton.Text = "Cancel";
            this.CanselButton.UseVisualStyleBackColor = true;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(12, 4);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.Location = new System.Drawing.Point(85, 12);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.Size = new System.Drawing.Size(390, 20);
            this.DataSourceTextBox.TabIndex = 0;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Enabled = false;
            this.UserIdTextBox.Location = new System.Drawing.Point(85, 38);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(390, 20);
            this.UserIdTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(85, 64);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(390, 20);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // DataBaseTextBox
            // 
            this.DataBaseTextBox.Location = new System.Drawing.Point(86, 90);
            this.DataBaseTextBox.Name = "DataBaseTextBox";
            this.DataBaseTextBox.Size = new System.Drawing.Size(389, 20);
            this.DataBaseTextBox.TabIndex = 6;
            // 
            // DataSourceLable
            // 
            this.DataSourceLable.AutoSize = true;
            this.DataSourceLable.Location = new System.Drawing.Point(12, 15);
            this.DataSourceLable.Name = "DataSourceLable";
            this.DataSourceLable.Size = new System.Drawing.Size(67, 13);
            this.DataSourceLable.TabIndex = 1;
            this.DataSourceLable.Text = "Data Source";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(26, 67);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(53, 13);
            this.PasswordLable.TabIndex = 5;
            this.PasswordLable.Text = "Password";
            // 
            // DataBaseLable
            // 
            this.DataBaseLable.AutoSize = true;
            this.DataBaseLable.Location = new System.Drawing.Point(26, 93);
            this.DataBaseLable.Name = "DataBaseLable";
            this.DataBaseLable.Size = new System.Drawing.Size(54, 13);
            this.DataBaseLable.TabIndex = 7;
            this.DataBaseLable.Text = "DataBase";
            // 
            // UserIdCheckBox
            // 
            this.UserIdCheckBox.AutoSize = true;
            this.UserIdCheckBox.Location = new System.Drawing.Point(17, 40);
            this.UserIdCheckBox.Name = "UserIdCheckBox";
            this.UserIdCheckBox.Size = new System.Drawing.Size(62, 17);
            this.UserIdCheckBox.TabIndex = 3;
            this.UserIdCheckBox.Text = "User ID";
            this.UserIdCheckBox.UseVisualStyleBackColor = true;
            this.UserIdCheckBox.CheckedChanged += new System.EventHandler(this.UserIdCheckBox_CheckedChanged);
            // 
            // DbConnectionSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 150);
            this.Controls.Add(this.UserIdCheckBox);
            this.Controls.Add(this.DataBaseLable);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.DataSourceLable);
            this.Controls.Add(this.DataBaseTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.DataSourceTextBox);
            this.Controls.Add(this.ButtonsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbConnectionSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Connection";
            this.Load += new System.EventHandler(this.DbConnectionSettingsForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox DataSourceTextBox;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox DataBaseTextBox;
        private System.Windows.Forms.Label DataSourceLable;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label DataBaseLable;
        private System.Windows.Forms.CheckBox UserIdCheckBox;
        private System.Windows.Forms.ProgressBar WaitingProgressBar;
    }
}