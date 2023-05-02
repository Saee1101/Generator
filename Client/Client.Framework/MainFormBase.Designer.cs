namespace Client.Framework
{
    partial class MainFormBase
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
            this.components = new System.ComponentModel.Container();
            this.StatusBarStrip = new System.Windows.Forms.StatusStrip();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropdwon1 = new Client.Framework.Dropdwon();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBarStrip
            // 
            this.StatusBarStrip.Location = new System.Drawing.Point(0, 746);
            this.StatusBarStrip.Name = "StatusBarStrip";
            this.StatusBarStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBarStrip.Size = new System.Drawing.Size(1329, 22);
            this.StatusBarStrip.TabIndex = 0;
            this.StatusBarStrip.Text = "statusStrip";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.dropdwon1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 40);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dropdwon1
            // 
            this.dropdwon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dropdwon1.IputMask = "";
            this.dropdwon1.Location = new System.Drawing.Point(191, 12);
            this.dropdwon1.Name = "dropdwon1";
            this.dropdwon1.Size = new System.Drawing.Size(994, 19);
            this.dropdwon1.TabIndex = 0;
            this.dropdwon1.Value = "";
            // 
            // MainFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusBarStrip);
            this.Name = "MainFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormBase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFormBase_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBarStrip;
        private System.Windows.Forms.Timer DateTimeTimer;
        private Dropdwon dropdwon1;
        private System.Windows.Forms.Panel panel1;
    }
}