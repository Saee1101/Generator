namespace Client.Framework
{
    partial class dateTimePiker1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CurrentCalendarLable = new System.Windows.Forms.Label();
            this.LastYearButton = new System.Windows.Forms.Button();
            this.LastMonthButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SelectedDateLable = new System.Windows.Forms.Label();
            this.CalendarGridView = new System.Windows.Forms.DataGridView();
            this.Day1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day4Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day5Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day6Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day7Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.CurrentCalendarLable);
            this.TopPanel.Controls.Add(this.LastYearButton);
            this.TopPanel.Controls.Add(this.LastMonthButton);
            this.TopPanel.Controls.Add(this.NextMonthButton);
            this.TopPanel.Controls.Add(this.NextYearButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopPanel.Size = new System.Drawing.Size(551, 49);
            this.TopPanel.TabIndex = 0;
            // 
            // CurrentCalendarLable
            // 
            this.CurrentCalendarLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentCalendarLable.Location = new System.Drawing.Point(165, 9);
            this.CurrentCalendarLable.Name = "CurrentCalendarLable";
            this.CurrentCalendarLable.Size = new System.Drawing.Size(217, 23);
            this.CurrentCalendarLable.TabIndex = 4;
            this.CurrentCalendarLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastYearButton
            // 
            this.LastYearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastYearButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastYearButton.Location = new System.Drawing.Point(471, 11);
            this.LastYearButton.Name = "LastYearButton";
            this.LastYearButton.Size = new System.Drawing.Size(75, 23);
            this.LastYearButton.TabIndex = 3;
            this.LastYearButton.Text = "سال قبل";
            this.LastYearButton.UseVisualStyleBackColor = true;
            this.LastYearButton.Click += new System.EventHandler(this.LastYearButton_Click);
            // 
            // LastMonthButton
            // 
            this.LastMonthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastMonthButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastMonthButton.Location = new System.Drawing.Point(388, 11);
            this.LastMonthButton.Name = "LastMonthButton";
            this.LastMonthButton.Size = new System.Drawing.Size(75, 23);
            this.LastMonthButton.TabIndex = 2;
            this.LastMonthButton.Text = "ماه قبل";
            this.LastMonthButton.UseVisualStyleBackColor = true;
            this.LastMonthButton.Click += new System.EventHandler(this.LastMonthButton_Click);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMonthButton.Location = new System.Drawing.Point(84, 9);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(75, 23);
            this.NextMonthButton.TabIndex = 1;
            this.NextMonthButton.Text = "ماه بعد";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // NextYearButton
            // 
            this.NextYearButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextYearButton.Location = new System.Drawing.Point(3, 9);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(75, 23);
            this.NextYearButton.TabIndex = 0;
            this.NextYearButton.Text = "سال بعد";
            this.NextYearButton.UseVisualStyleBackColor = true;
            this.NextYearButton.Click += new System.EventHandler(this.NextYearButton_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.SelectedDateLable);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 394);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(551, 47);
            this.ButtonPanel.TabIndex = 1;
            // 
            // SelectedDateLable
            // 
            this.SelectedDateLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedDateLable.Location = new System.Drawing.Point(150, 12);
            this.SelectedDateLable.Name = "SelectedDateLable";
            this.SelectedDateLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SelectedDateLable.Size = new System.Drawing.Size(258, 23);
            this.SelectedDateLable.TabIndex = 4;
            this.SelectedDateLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarGridView
            // 
            this.CalendarGridView.AllowUserToAddRows = false;
            this.CalendarGridView.AllowUserToDeleteRows = false;
            this.CalendarGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CalendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalendarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day1Column,
            this.Day2Column,
            this.Day3Column,
            this.Day4Column,
            this.Day5Column,
            this.Day6Column,
            this.Day7Column});
            this.CalendarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarGridView.Location = new System.Drawing.Point(0, 49);
            this.CalendarGridView.MultiSelect = false;
            this.CalendarGridView.Name = "CalendarGridView";
            this.CalendarGridView.ReadOnly = true;
            this.CalendarGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CalendarGridView.RowHeadersVisible = false;
            this.CalendarGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CalendarGridView.Size = new System.Drawing.Size(551, 345);
            this.CalendarGridView.TabIndex = 2;
            // 
            // Day1Column
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day1Column.DefaultCellStyle = dataGridViewCellStyle15;
            this.Day1Column.HeaderText = "شنبه";
            this.Day1Column.Name = "Day1Column";
            this.Day1Column.ReadOnly = true;
            // 
            // Day2Column
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day2Column.DefaultCellStyle = dataGridViewCellStyle16;
            this.Day2Column.HeaderText = "یکشنبه";
            this.Day2Column.Name = "Day2Column";
            this.Day2Column.ReadOnly = true;
            // 
            // Day3Column
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day3Column.DefaultCellStyle = dataGridViewCellStyle17;
            this.Day3Column.HeaderText = "دوشنبه";
            this.Day3Column.Name = "Day3Column";
            this.Day3Column.ReadOnly = true;
            // 
            // Day4Column
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day4Column.DefaultCellStyle = dataGridViewCellStyle18;
            this.Day4Column.HeaderText = "سه شنبه";
            this.Day4Column.Name = "Day4Column";
            this.Day4Column.ReadOnly = true;
            // 
            // Day5Column
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day5Column.DefaultCellStyle = dataGridViewCellStyle19;
            this.Day5Column.HeaderText = "چهارشنبه";
            this.Day5Column.Name = "Day5Column";
            this.Day5Column.ReadOnly = true;
            // 
            // Day6Column
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day6Column.DefaultCellStyle = dataGridViewCellStyle20;
            this.Day6Column.HeaderText = "پنج شنبه";
            this.Day6Column.Name = "Day6Column";
            this.Day6Column.ReadOnly = true;
            // 
            // Day7Column
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day7Column.DefaultCellStyle = dataGridViewCellStyle21;
            this.Day7Column.HeaderText = "جمعه";
            this.Day7Column.Name = "Day7Column";
            this.Day7Column.ReadOnly = true;
            // 
            // dateTimePiker1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CalendarGridView);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "dateTimePiker1";
            this.Size = new System.Drawing.Size(551, 441);
            this.Load += new System.EventHandler(this.dateTimePiker1_Load);
            this.TopPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.DataGridView CalendarGridView;
        private System.Windows.Forms.Label SelectedDateLable;
        private System.Windows.Forms.Button LastYearButton;
        private System.Windows.Forms.Button LastMonthButton;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button NextYearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day5Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day6Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day7Column;
        private System.Windows.Forms.Label CurrentCalendarLable;
    }
}
