using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;


namespace Client.Framework
{
    public partial class MainFormBase :Form
    {
        //public Models.FinancialYearModel f { get; set; }
        //public Framework.Dropdwon dropdown { get; set; }  
       
       
        public MainFormBase()
        {
            
            InitializeComponent();
           
            //var baseInfoItem=(ToolStripMenuItem) MainMenuStrip.Items.Add("File", null, null);
            // baseInfoItem.DropDownItems.Add("new", null,(obj,e)=>
            // {
            //     MessageBox.Show("Welcom");
            // });
            var toolstripLable = new ToolStripLabel();
            DateTimeTimer.Tick += (obj, e) =>
             {
                 toolstripLable.Text = DateTime.Now.ToString("hh:mm:ss yyyy/MM/dd");
             };
            DateTimeTimer.Interval = 1000;
            StatusBarStrip.Items.Add(toolstripLable);
            DateTimeTimer.Start();

        }
     

        protected void MainFormBase_Load(object sender, EventArgs e)
        {


            var date1="";
            
            dropdwon1.Value = DateTime.Now.ToString("yyyy/MM/dd");
            var picker = new dateTimePiker1();
            //dropdwon1.Value = picker.SelectedDate.ToString("yyyy/MM/dd");
            dropdwon1.IputMask = "0000/00/00";
            dropdwon1.RightToLeft = RightToLeft.No;
            //dropdwon1.OnValueChanged += (obj, args) =>
            // {
            //     dropdwon1.Tag = dropdwon1.Value.ConvertToDate();
            // };

            dropdwon1.GetDropdownControl += () =>
            {
                var grid = new DataGridView();
                picker.OnDateDoubleClick += (obj, args) =>
                  {
                      
                      dropdwon1.CloseDropdown();
                      //var g = this.CreateGraphics();
                      //g.DrawEllipse(new Pen(Color.Black), 300, 300, 500, 500);
                  
                                           
                      grid.Columns.Clear();
                      this.Controls.Add(grid);
                      grid.Location = new Point(0, 40);

                      grid.Size = new Size(1590, 850);
                      grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                      grid.Columns.Add(new DataGridViewTextBoxColumn()
                      {
                          HeaderText = "Product",
                          DataPropertyName = "Titel"
                      });
                      grid.Columns.Add(new DataGridViewTextBoxColumn()
                      {
                          HeaderText = "Model",
                          DataPropertyName = "Titel1"
                      });
                      grid.Columns.Add(new DataGridViewTextBoxColumn()
                      {
                          HeaderText = "Nominal",
                          DataPropertyName = "Titel2"
                      });
                
                      using (var connection = new SqlConnection("Data Source=.;Initial Catalog=TivanEX;Integrated Security=SSPI;MultipleActiveResultSets=true"))
                      {
                          
                          connection.Open();
                          var command = new SqlCommand("select Type.Titel,Model.Titel,Nominal.Titel,faults.Value from Type inner join Nominal on Type.Id=Nominal.TypeId inner join Model on Model.Id=Nominal.ModelId inner join faults on faults.NominalId = Nominal.Id where Date ='"+date1+"'", connection);

                          var reader = command.ExecuteReader();
                          DataTable table = new DataTable();

                          table.Load(reader);
                          grid.DataSource = table;
                      }
                      
                  };
                if(dropdwon1.Tag != null)
                {
                    
                    picker.SelectedDate = (DateTime)dropdwon1.Tag;
                }
                picker.OnSelectedDateChanged += (s, args) =>
                {
                    dropdwon1.Value = picker.SelectedDate.ToString("yyyy/MM/dd");

                    //MainFormBase date = new MainFormBase(picker.SelectedDate.ToString("yyyy/MM/dd"));
                    date1 = picker.SelectedDate.ToString("yyyy/MM/dd");
                   
                   // var financial = new Models.FinancialYearModel();
                   // financial.date = picker.SelectedDate.ToString("yyyy/MM/dd");
                   // var startDateYear = financial.date.Split('/')[0];
                   // var startDateMonth = financial.date.Split('/')[1];
                   // var startDateDay = financial.date.Split('/')[2];
                 
                   //Da.Date = new DateTime(int.Parse(startDateYear), int.Parse(startDateMonth), int.Parse(startDateDay)
                   //    ,new PersianCalendar());


                    dropdwon1.Tag = picker.SelectedDate;


                };
                return picker;
            };


        }

        private void CalendarGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
