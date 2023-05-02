using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Test
{
   
    public partial class Form1 : Form
    {
        IRepository repository;
        public Form1(IRepository repository)
        {
            this.repository = repository;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
