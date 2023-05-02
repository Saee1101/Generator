using System;
using System.Windows.Forms;
using Client.RepositoryAbstracts;

namespace Client.Win.Views.SystemForms
{
    public partial class SplashScreenForm : Form
    {
        IDbTools dbTools;
        public SplashScreenForm(IDbTools dbTools)
        {
            this.dbTools=dbTools;
            InitializeComponent();
        }
       
        private async void SplashScreenForm_Load(object sender, EventArgs e)
        {
           StatuseLable.Text = "LOODING.....";
           
            //var serverIsConnected = await CheckSqlConnection();
            //if (!serverIsConnected)
            if(!await dbTools.CheckDbConnection())
            {
                StatuseLable.Text = "Coneecting to server.....";
                var contanair = new StructureMap.Container(new IoC.TypeRegistry());
                var connectionStringsForm = contanair.GetInstance<DbConnectionSettingsForm>();
                //var connectionStringsForm = new DbConnectionSettingsForm();
                var result = connectionStringsForm.ShowDialog();
                if(result !=DialogResult.OK)
                DialogResult = DialogResult.Cancel;
            }
            dbTools.RefreshConnectionString();
            StatuseLable.Text = "Checking server.....";
            //if (!await  CheckDatabaseExists())
            //   await CreateDatabase() ;
            if(!await dbTools.CheckDatabaseExists())
            {
                StatuseLable.Text = "Creating server.....";
                if (!await dbTools.CreatDatabase(Properties.Resources.TivanEXscript))
                {
                    DialogResult = DialogResult.Cancel;
                    return;
                }

            }
            DialogResult = DialogResult.OK;

        }
        //private async Task<bool> CheckSqlConnection & CheckExists & Creating()
        //{
        //    StatuseLable.Text = "Checking server.....";
        //    var connectionstring = ConfigurationManager.ConnectionStrings["DbconnectionString"].ConnectionString;
        //    var connectionstringBuilder = new SqlConnectionStringBuilder(connectionstring);
        //    connectionstringBuilder.InitialCatalog = "master";
        //    try
        //    {
        //        using (var connection=new SqlConnection(connectionstring))
        //        {
        //            await connection.OpenAsync();
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        var connectionSetingsForm = new Views.SystemForms.DbConnectionSettingsForm();
        //        var result = connectionSetingsForm.ShowDialog();
        //       return result == DialogResult.OK;
            
        //    }
            
           
        //}
        //private async Task<bool> CheckDatabaseExists()
        //{
        //    StatuseLable.Text = "Checking server.....";
        //    var connectionstring = ConfigurationManager.ConnectionStrings["DbconnectionString"].ConnectionString;
        //    var connectionstringBuilder = new SqlConnectionStringBuilder(connectionstring);
        //    var tempDbName = connectionstringBuilder.InitialCatalog;
        //    connectionstringBuilder.InitialCatalog = "master";
        //    try
        //    {
        //        using (var connection = new SqlConnection(connectionstringBuilder.ConnectionString))
        //        {
        //            await connection.OpenAsync();
        //            var command = connection.CreateCommand();
        //            command.CommandText = "select count(*) from sys.databases where [name]=@dbname";
        //            command.Parameters.Add(new SqlParameter("dbname", tempDbName));
        //            var result = (int)await command.ExecuteScalarAsync();
        //            return result > 0;

        //        }
               
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("There Is Problem", "System Message");
        //        DialogResult = DialogResult.Cancel;
        //    }
        //    return false;
        //}
        //private async Task<bool> CreateDatabase()
        //{
        //    StatuseLable.Text = "Creating server.....";
        //    var connectionstring = ConfigurationManager.ConnectionStrings["DbconnectionString"].ConnectionString;
        //    var connectionstringBuilder = new SqlConnectionStringBuilder(connectionstring);
        //    var tempDbName = connectionstringBuilder.InitialCatalog;
        //    connectionstringBuilder.InitialCatalog = "master";
        //    try
        //    {
        //        using (var connection = new SqlConnection(connectionstringBuilder.ConnectionString))
        //        {
        //            await connection.OpenAsync();
        //            var command = connection.CreateCommand();
        //            command.CommandText ="create database "+tempDbName;
        //            await command.ExecuteNonQueryAsync();
        //            connection.ChangeDatabase(tempDbName);
                              
        //            var createTablesCommand = connection.CreateCommand();
        //            createTablesCommand.CommandText = Properties.Resources.TivanEXscript.Replace("GO", "")
        //              .Replace("TivanEX", "[" + tempDbName + "]");
        //           await createTablesCommand.ExecuteNonQueryAsync();
        //          return true;
        //        }
            
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("There Is Problem", "System Message");
        //        DialogResult = DialogResult.Cancel;
        //    }
        //    return false;
        //}

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
 
    }
}
