namespace DbClassGenerator
{
    partial class Form1
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
            this.DataSourceLable = new System.Windows.Forms.Label();
            this.DataSourceTxt = new System.Windows.Forms.TextBox();
            this.UserIDchekbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIDTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.DataBaseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TablesCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.RootNamespaceLab = new System.Windows.Forms.Label();
            this.RootNamespaceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DataSourceLable
            // 
            this.DataSourceLable.AutoSize = true;
            this.DataSourceLable.Location = new System.Drawing.Point(12, 9);
            this.DataSourceLable.Name = "DataSourceLable";
            this.DataSourceLable.Size = new System.Drawing.Size(64, 13);
            this.DataSourceLable.TabIndex = 0;
            this.DataSourceLable.Text = "DataSource";
            // 
            // DataSourceTxt
            // 
            this.DataSourceTxt.Location = new System.Drawing.Point(82, 6);
            this.DataSourceTxt.Name = "DataSourceTxt";
            this.DataSourceTxt.Size = new System.Drawing.Size(100, 20);
            this.DataSourceTxt.TabIndex = 1;
            // 
            // UserIDchekbox
            // 
            this.UserIDchekbox.AutoSize = true;
            this.UserIDchekbox.Location = new System.Drawing.Point(199, 8);
            this.UserIDchekbox.Name = "UserIDchekbox";
            this.UserIDchekbox.Size = new System.Drawing.Size(62, 17);
            this.UserIDchekbox.TabIndex = 2;
            this.UserIDchekbox.Text = "User ID";
            this.UserIDchekbox.UseVisualStyleBackColor = true;
            this.UserIDchekbox.CheckedChanged += new System.EventHandler(this.UserIDchekbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // UserIDTxt
            // 
            this.UserIDTxt.Enabled = false;
            this.UserIDTxt.Location = new System.Drawing.Point(267, 6);
            this.UserIDTxt.Name = "UserIDTxt";
            this.UserIDTxt.Size = new System.Drawing.Size(99, 20);
            this.UserIDTxt.TabIndex = 4;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Enabled = false;
            this.PasswordTxt.Location = new System.Drawing.Point(431, 6);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxt.TabIndex = 5;
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(537, 4);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(75, 23);
            this.Connectbtn.TabIndex = 6;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // DataBaseComboBox
            // 
            this.DataBaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBaseComboBox.FormattingEnabled = true;
            this.DataBaseComboBox.Location = new System.Drawing.Point(82, 31);
            this.DataBaseComboBox.Name = "DataBaseComboBox";
            this.DataBaseComboBox.Size = new System.Drawing.Size(530, 21);
            this.DataBaseComboBox.TabIndex = 7;
            this.DataBaseComboBox.SelectedIndexChanged += new System.EventHandler(this.DataBaseComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "DataSource";
            // 
            // TablesCheckListBox
            // 
            this.TablesCheckListBox.FormattingEnabled = true;
            this.TablesCheckListBox.Location = new System.Drawing.Point(19, 58);
            this.TablesCheckListBox.Name = "TablesCheckListBox";
            this.TablesCheckListBox.Size = new System.Drawing.Size(597, 289);
            this.TablesCheckListBox.TabIndex = 9;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(537, 353);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 10;
            this.GenerateBtn.Text = "Generate...";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // RootNamespaceLab
            // 
            this.RootNamespaceLab.AutoSize = true;
            this.RootNamespaceLab.Location = new System.Drawing.Point(12, 358);
            this.RootNamespaceLab.Name = "RootNamespaceLab";
            this.RootNamespaceLab.Size = new System.Drawing.Size(90, 13);
            this.RootNamespaceLab.TabIndex = 11;
            this.RootNamespaceLab.Text = "Root Namespace";
            // 
            // RootNamespaceTextBox
            // 
            this.RootNamespaceTextBox.Location = new System.Drawing.Point(108, 353);
            this.RootNamespaceTextBox.Name = "RootNamespaceTextBox";
            this.RootNamespaceTextBox.Size = new System.Drawing.Size(423, 20);
            this.RootNamespaceTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 386);
            this.Controls.Add(this.RootNamespaceTextBox);
            this.Controls.Add(this.RootNamespaceLab);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.TablesCheckListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataBaseComboBox);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UserIDTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserIDchekbox);
            this.Controls.Add(this.DataSourceTxt);
            this.Controls.Add(this.DataSourceLable);
            this.Name = "Form1";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataSourceLable;
        private System.Windows.Forms.TextBox DataSourceTxt;
        private System.Windows.Forms.CheckBox UserIDchekbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserIDTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.ComboBox DataBaseComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox TablesCheckListBox;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Label RootNamespaceLab;
        private System.Windows.Forms.TextBox RootNamespaceTextBox;
    }
}

