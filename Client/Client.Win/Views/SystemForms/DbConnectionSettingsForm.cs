using Client.RepositoryAbstracts;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Client.Win.Views.SystemForms
{
    public partial class DbConnectionSettingsForm : Form
    {
        IDbTools dbTools;
        public DbConnectionSettingsForm(IDbTools dbTools)
        {
            this.dbTools = dbTools;
            InitializeComponent();
        }

        private void DbConnectionSettingsForm_Load(object sender, EventArgs e)
        {
            FillContorols();
            //var connectionstring = ConfigurationManager.ConnectionStrings["DbconnectionString"].ConnectionString;
            //var connectionstringBuilder = new SqlConnectionStringBuilder(connectionstring);
            //DataSourceTextBox.Text = connectionstringBuilder.DataSource;
            //UserIdCheckBox.Checked =! connectionstringBuilder.IntegratedSecurity;
            //if(!connectionstringBuilder.IntegratedSecurity)
            //{
            //    UserIdTextBox.Text = connectionstringBuilder.UserID;
            //    PasswordTextBox.Text = connectionstringBuilder.Password;
            //}
            //DataBaseTextBox.Text = connectionstringBuilder.InitialCatalog;
        }

        private void UserIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserIdTextBox.Enabled = PasswordTextBox.Enabled = UserIdCheckBox.Checked;
        }

        private async void AcceptButton_Click(object sender, EventArgs e)
        {
           
            Helpers.ConfigurationTools.UpdateConnectionStrings("DbconnectionString", DataSourceTextBox.Text, DataBaseTextBox.Text,
                !UserIdCheckBox.Checked,UserIdTextBox.Text, PasswordTextBox.Text);
            dbTools.RefreshConnectionString();
            var userIdchecked = UserIdCheckBox.Checked;

            ChangeControlsStatus(false);
            //CanselButton.Enabled = AcceptButton.Enabled = DataBaseTextBox.Enabled =
            //    PasswordTextBox.Enabled = DataSourceTextBox.Enabled =
            //    UserIdTextBox.Enabled = UserIdCheckBox.Enabled = false;
            //WaitingProgressBar.Visible = true;

            var connected = await dbTools.CheckDbConnection();

            ChangeControlsStatus(true);
            //CanselButton.Enabled = AcceptButton.Enabled = DataBaseTextBox.Enabled =
            //  PasswordTextBox.Enabled = DataSourceTextBox.Enabled =
            //  UserIdTextBox.Enabled = true;
            //UserIdCheckBox.Checked = userIdchecked;
            //WaitingProgressBar.Visible = false;
            //var connectionStringBuilder = new SqlConnectionStringBuilder();
            //connectionStringBuilder.DataSource = DataSourceTextBox.Text;
            //connectionStringBuilder.IntegratedSecurity = !UserIdCheckBox.Checked;
            //if (UserIdCheckBox.Checked)
            //{
            //    connectionStringBuilder.UserID = UserIdTextBox.Text;
            //    connectionStringBuilder.Password = UserIdTextBox.Text;
            //}
            if (! connected)
            {
                MessageBox.Show("Connection Setting is False. ", "System Message");
            }
            else
            {
                MessageBox.Show("Connection is Right.", "System Message");
                DialogResult = DialogResult.OK;
            }
            //connectionStringBuilder.InitialCatalog = "master";
            //try
            //{
            //    using (var connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            //    {
            //        await connection.OpenAsync();
            //    }
            //    MessageBox.Show("Connection is Right.", "System Message");
            //    //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //    //var connectionstrings = (ConnectionStringsSection)config.GetSection("connectionStrings");
            //    //connectionStringBuilder.InitialCatalog = DataBaseTextBox.Text;
            //    //connectionstrings.ConnectionStrings["DbconnectionString"].ConnectionString = connectionStringBuilder.ConnectionString;
            //    //config.Save(ConfigurationSaveMode.Modified);
            //    //ConfigurationManager.RefreshSection("connectionStrings");
            //    DialogResult = DialogResult.OK;
            //}
            
            //catch (Exception ex)
            //{
            //    //var connectionSetingsForm = new Views.SystemForms.DbConnectionSettingsForm();
            //    //connectionSetingsForm.ShowDialog();
            //    MessageBox.Show("Connection Setting is False. ","System Message");
            //}
            //finally
            //{

            //    CanselButton.Enabled = AcceptButton.Enabled = DataBaseTextBox.Enabled =
            //   PasswordTextBox.Enabled = DataSourceTextBox.Enabled =
            //   UserIdTextBox.Enabled = true;
            //    UserIdCheckBox.Checked = userIdchecked;
            //    WaitingProgressBar.Visible = false;
            //}
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void WaitingProgressBar_Click(object sender, EventArgs e)
        {

        }
        private void FillContorols()
        {
            var connectionstring = ConfigurationManager.ConnectionStrings["DbconnectionString"].ConnectionString;
            var connectionstringBuilder = new SqlConnectionStringBuilder(connectionstring);
            DataSourceTextBox.Text = connectionstringBuilder.DataSource;
            UserIdCheckBox.Checked = !connectionstringBuilder.IntegratedSecurity;
            if (!connectionstringBuilder.IntegratedSecurity)
            {
                UserIdTextBox.Text = connectionstringBuilder.UserID;
                PasswordTextBox.Text = connectionstringBuilder.Password;
            }
            DataBaseTextBox.Text = connectionstringBuilder.InitialCatalog;
        }
        private void  ChangeControlsStatus(bool status)
        {
            CanselButton.Enabled = AcceptButton.Enabled = DataBaseTextBox.Enabled =
    PasswordTextBox.Enabled = DataSourceTextBox.Enabled =
    UserIdTextBox.Enabled = UserIdCheckBox.Enabled = status;
            WaitingProgressBar.Visible = !status;
        }
    }
}
