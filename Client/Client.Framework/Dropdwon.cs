using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Framework
{
    public partial class Dropdwon : UserControl
    {
        private Form dropdownForm;
        public event EventHandler OnValueChanged;
        public Dropdwon()
        {
            InitializeComponent();
            DropdownInputmaskedEdit.TextChanged += DropdownInputmaskedEdit_TextChanged;
        }

        private void DropdownInputmaskedEdit_TextChanged(object sender, EventArgs e)
        {
            if (OnValueChanged != null)
                OnValueChanged(this, new EventArgs());
        }

        public string Value
        {
            get { return DropdownInputmaskedEdit.Text; }
            set { DropdownInputmaskedEdit.Text = value; }
        }
        public string IputMask
        {
            get { return DropdownInputmaskedEdit.Mask; }
            set { DropdownInputmaskedEdit.Mask = value; }
        }
        public Func<Control> GetDropdownControl;
        //dateTimePiker1 d = new dateTimePiker1();
        private void ShowDropdownButton_Click(object sender, EventArgs e)
        {
            dropdownForm = new Form();
            dropdownForm.FormBorderStyle = FormBorderStyle.None;
            dropdownForm.BackColor = Color.Gainsboro;
            var screenlocation = this.PointToScreen(Point.Empty);
            dropdownForm.Width = 919;
            dropdownForm.Height = 600;
            dropdownForm.ShowInTaskbar = false;
            dropdownForm.TopMost = true;
            if(GetDropdownControl != null)
            {
                var control = GetDropdownControl();
                dropdownForm.Controls.Add(control);
                control.Dock = DockStyle.Fill;
            }

            dropdownForm.Show();
         
            dropdownForm.Deactivate += (s, args) =>
             {
                 //dropdownForm.Close();
                 dropdownForm.Hide();
                 dropdownForm = null;
             };
            screenlocation.Y += this.Height;
            screenlocation.X =screenlocation.X + (Width - dropdownForm.Width);
            dropdownForm.Location = screenlocation;
            //d.OnSelectedDateChanged += D_OnSelectedDateChanged;
        }
        public void CloseDropdown()
        {
            if (dropdownForm != null)
                //dropdownForm.Close();
            dropdownForm.Hide();

        }
        //private void D_OnSelectedDateChanged(object sender, EventArgs e)
        //{

        //}
    }
}
