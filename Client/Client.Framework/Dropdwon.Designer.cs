namespace Client.Framework
{
    partial class Dropdwon
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
            this.ShowDropdownButton = new System.Windows.Forms.Button();
            this.DropdownInputmaskedEdit = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ShowDropdownButton
            // 
            this.ShowDropdownButton.AutoSize = true;
            this.ShowDropdownButton.Location = new System.Drawing.Point(-1, -2);
            this.ShowDropdownButton.Name = "ShowDropdownButton";
            this.ShowDropdownButton.Size = new System.Drawing.Size(78, 23);
            this.ShowDropdownButton.TabIndex = 0;
            this.ShowDropdownButton.Text = "DATE";
            this.ShowDropdownButton.UseVisualStyleBackColor = true;
            this.ShowDropdownButton.Click += new System.EventHandler(this.ShowDropdownButton_Click);
            // 
            // DropdownInputmaskedEdit
            // 
            this.DropdownInputmaskedEdit.Location = new System.Drawing.Point(75, 0);
            this.DropdownInputmaskedEdit.Name = "DropdownInputmaskedEdit";
            this.DropdownInputmaskedEdit.Size = new System.Drawing.Size(919, 20);
            this.DropdownInputmaskedEdit.TabIndex = 1;
            // 
            // Dropdwon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.DropdownInputmaskedEdit);
            this.Controls.Add(this.ShowDropdownButton);
            this.Name = "Dropdwon";
            this.Size = new System.Drawing.Size(994, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowDropdownButton;
        private System.Windows.Forms.MaskedTextBox DropdownInputmaskedEdit;
    }
}
