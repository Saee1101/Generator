using System.Threading.Tasks;

namespace Client.RepositoryAbstracts
{
    public interface IDbTools
    {
        Task<bool> CheckDbConnection();
        Task<bool> CheckDatabaseExists();
        Task<bool> CreatDatabase(string dbScript);
        void RefreshConnectionString();

    }
}
