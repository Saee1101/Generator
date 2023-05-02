using System.Configuration;
using System.Data.SqlClient;

namespace Client.Win.Helpers
{
    public class ConfigurationTools
    {
        public static void UpdateConnectionStrings(string connectionName,string dataSource,string initialCatalog,bool integrateSecurity,string userId,string password)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = dataSource;
            connectionStringBuilder.IntegratedSecurity = !integrateSecurity;
            if (!integrateSecurity)
            {
                connectionStringBuilder.UserID = userId;
                connectionStringBuilder.Password = password;
            }
            var connectionstrings = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringBuilder.InitialCatalog =initialCatalog;
            connectionstrings.ConnectionStrings[connectionName].ConnectionString = connectionStringBuilder.ConnectionString;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
