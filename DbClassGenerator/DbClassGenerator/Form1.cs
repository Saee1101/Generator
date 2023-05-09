using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DbClassGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
        }
        private void UserIDchekbox_CheckedChanged(object sender, EventArgs e)
        {
            UserIDTxt.Enabled = PasswordTxt.Enabled = UserIDchekbox.Checked;
            if (UserIDchekbox.Checked)
                UserIDTxt.Focus();
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
          using (var connection = new SqlConnection(GetSqlConnectionString("master")))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM sys.databases", connection);
                var reader = command.ExecuteReader();
                DataBaseComboBox.Items.Clear();
                while (reader.Read())
                {
                    DataBaseComboBox.Items.Add(reader["name"]);
                }
                DataBaseComboBox.Enabled = true; 
            }
                
        }
        private string GetSqlConnectionString (string databaseName)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = DataSourceTxt.Text;
            connectionStringBuilder.InitialCatalog = databaseName;
            connectionStringBuilder.MultipleActiveResultSets = true;
            if (UserIDchekbox.Checked)
            {
                connectionStringBuilder.IntegratedSecurity = false;
                connectionStringBuilder.UserID = UserIDTxt.Text;
                connectionStringBuilder.Password = PasswordTxt.Text;
            }
            else
                connectionStringBuilder.IntegratedSecurity = true;
            return connectionStringBuilder.ConnectionString;
        }
        private void DataBaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connectionstrig = GetSqlConnectionString(DataBaseComboBox.SelectedItem.ToString());
            using (var connection = new SqlConnection(connectionstrig))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES",connection);
                var reader = command.ExecuteReader();
                TablesCheckListBox.Items.Clear();
                while (reader.Read())
                {
                    var schema = reader["TABLE_SCHEMA"];
                    var table = reader["TABLE_NAME"];                  
                    TablesCheckListBox.Items.Add(schema + "." + table);
                }

            }
        }
       
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            var FolderBrowser = new FolderBrowserDialog();
            if (FolderBrowser.ShowDialog() != DialogResult.OK)
                return;
          
            foreach (var item in TablesCheckListBox.CheckedItems)
            {
                var text = item.ToString();
                var schema = text.Split('.')[0];
                var table = text.Split('.')[1];
                var columns = GetTableColumns(schema, table);
                GenerateEntities(FolderBrowser.SelectedPath, schema, table, columns);
                GenerateRepositoryInterfaces(FolderBrowser.SelectedPath, schema, table, columns);
                GenerateRepositories(FolderBrowser.SelectedPath, schema, table, columns);
                
            }
        }
        private void GenerateRepositories(string generatePath, string schema, string table, List<ColumnModel> columns)
        {
            var EntitiesFolder = Path.Combine(generatePath, "Repositories");
            if (!Directory.Exists(EntitiesFolder))
                Directory.CreateDirectory(EntitiesFolder);
            List<string> classLine = new List<string>();
            classLine.Add("using System;");
            classLine.Add("using System.Collections.Generic;");
            classLine.Add("using System.Data.SqlClient;");
            classLine.Add("");
            classLine.Add("namespace " + RootNamespaceTextBox.Text + ".Repositories");
            classLine.Add("{");
            classLine.Add("      public class " + table + "Repository : DataLayer.GenericRepository<Entities." + GetSingularName(table) +">"+",RepositoryAbstracts.I"+table+ "Repository");
            classLine.Add("     {");
            classLine.Add("        public " + table + "Repository(): base(\"name=DbconnectionString\") { }");
            foreach (var column in columns)
            {
                var dataType = ConvertSqlTypetoClr(column.DataType, column.IsNullable);
                classLine.Add("        public List<Entities." + GetSingularName(table) + "> GetBy" + column.Name + "(" + ConvertSqlTypetoClr(column.DataType, column.IsNullable) + " value) ");
                classLine.Add("        {");
                if(dataType=="string")
                {
                    classLine.Add("             return Runquery(\"SELECT * FROM[" + schema + "].[" + table + "] WHERE ["+column.Name+"] LIKE @Value\",new SqlParameter(\"Value\", value)); ");
                }
                else
                {
                    classLine.Add("             return Runquery(\"SELECT * FROM[" + schema + "].[" + table + "] WHERE [" + column.Name + "] = @Value\",new SqlParameter(\"Value\", value)); ");
                }
                classLine.Add("         }");
            }
            classLine.Add("     }");
            classLine.Add("}");
            File.WriteAllLines(Path.Combine(EntitiesFolder, GetSingularName(table) + ".cs"), classLine);
        }
        private void GenerateRepositoryInterfaces(string generatePath, string schema, string table,List<ColumnModel>columns)
        {
            var EntitiesFolder = Path.Combine(generatePath, "Abstracts");
            if (!Directory.Exists(EntitiesFolder))
                Directory.CreateDirectory(EntitiesFolder);
            List<string> classLine = new List<string>();
            classLine.Add("using System;");
            classLine.Add("using System.Collections.Generic;");
            classLine.Add("");
            classLine.Add("namespace " + RootNamespaceTextBox.Text + ".RepositoryAbstracts");
            classLine.Add("{");
            classLine.Add("      public interface I" + table+ "Repository : DataLayer.IRepository<Entities."+GetSingularName(table)+">");
            classLine.Add("     {");
            foreach (var column in columns)
            {
                classLine.Add("        List<Entities." + GetSingularName(table) + "> GetBy"+column.Name+"("+ConvertSqlTypetoClr(column.DataType,column.IsNullable)+" value) ;");
            }
            classLine.Add("     }");
            classLine.Add("}");
            File.WriteAllLines(Path.Combine(EntitiesFolder, GetSingularName(table) + ".cs"), classLine);
        }
        private void GenerateEntities(string generatePath,string schema, string table,List<ColumnModel> columns)
        {
            var EntitiesFolder = Path.Combine(generatePath, "Entities");
            if (!Directory.Exists(EntitiesFolder))
                Directory.CreateDirectory(EntitiesFolder);
            List<string> classLine = new List<string>();
            classLine.Add("using System;");
            classLine.Add("");
            classLine.Add("namespace " + RootNamespaceTextBox.Text + ".Entities");
            classLine.Add("{");
            classLine.Add("   [DataLayer.Table(\"" + schema + "\",\"" + table + "\")]");
            classLine.Add("      public class " + GetSingularName(table));
            classLine.Add("     {");
            foreach (var column in columns)
            {
                if (column.IsPrimeryKey)
                {
                    classLine.Add("         [DataLayer.PrimaryKey]");
                }
                if (column.IsCommputed)
                {
                    classLine.Add("         [DataLayer.ComputedColumn]");
                }
                classLine.Add("       public " + ConvertSqlTypetoClr(column.DataType, column.IsNullable) + " " + column.Name + " {get;set;}");
            }
            classLine.Add("     }");
            classLine.Add("}");
            File.WriteAllLines(Path.Combine(EntitiesFolder, GetSingularName(table) + ".cs"), classLine);
        }
        private string ConvertSqlTypetoClr(string type,bool nullable)
        {
            switch (type)
            {
                case "int":
                    return nullable ? "int?" : "int";
                case "bigint":
                    return nullable ? "long?" : "long";
                case "datetime":
                    return nullable ? "DateTime" : "DateTime";
                case "nvarchar":
                case "char":
                case "varchar":
                case "nchar":
                    return "string";
                case "bit":
                    return nullable ? "bool?" : "bool";
                case "binery":
                case "image":
                    return "byte[]";
                case "decimal":
                    return nullable ? "decimal?" : "decimal";
                case "float":
                    return nullable ? "float?" : "float";
            }
            return "object"; 
        }
        private string GetSingularName(string name)
        {
            if(name.EndsWith("ies"))
                return name.Substring(0, name.Length - 3) + "y";
            else if(name.EndsWith("s"))
            return name.Substring(0, name.Length - 1);
            return name;
        }
        private List<ColumnModel> GetTableColumns(string schema, string tableName)
        {
            var Columns = new List<ColumnModel>();
            List<string> PrimeryKeyColumns = new List<string>();
            List<string> ComputedColumns = new List<string>();
            using (var connection = new SqlConnection(GetSqlConnectionString(DataBaseComboBox.SelectedItem.ToString())))
            {
                connection.Open();
                
                var keyscommand = new SqlCommand("select tc.TABLE_SCHEMA , tc.TABLE_NAME , ccu.COLUMN_NAME from INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc inner join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu on ccu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME where tc.TABLE_SCHEMA = N'" + schema + "' AND tc.TABLE_NAME = N'" + tableName + "' AND tc.CONSTRAINT_TYPE = N'PRIMARY KEY'", connection);
                var keysReader = keyscommand.ExecuteReader();
                while (keysReader.Read())
                {
                    PrimeryKeyColumns.Add(keysReader["COLUMN_NAME"].ToString());
                }
                var computedcommand = new SqlCommand("select [name] from sys.all_columns where object_id = object_id('"+ schema + "." + tableName +"') and (is_identity=1 OR is_computed=1)",connection);
                var computedReader = computedcommand.ExecuteReader();
                while (computedReader.Read())
                {
                    ComputedColumns.Add(computedReader["name"].ToString());
                }
                var command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.COLUMNS where TABLE_SCHEMA =N'" + schema + "' AND TABLE_NAME=N'" + tableName + "'", connection);
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    var columnModel = new ColumnModel()
                    {
                        IsPrimeryKey = PrimeryKeyColumns.Any(Col => Col.Equals(reader["COLUMN_NAME"])),
                        IsCommputed = ComputedColumns.Any(Col => Col.Equals(reader["COLUMN_NAME"])),
                        Name = reader["COLUMN_NAME"].ToString(),
                        DataType = reader["DATA_TYPE"].ToString(),
                        IsNullable = reader["IS_NULLABLE"].ToString()=="YES"
                    };
                    Columns.Add(columnModel);
                }
            }

                return Columns;
        }
    }
    public class ColumnModel
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        
        public bool IsPrimeryKey { get; set; }
        public bool IsCommputed { get; set; }
        public bool IsNullable { get; set; }
    }
}
