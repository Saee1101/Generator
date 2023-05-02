using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Client.Repositories
{
      public class UsersRepository : DataLayer.GenericRepository<Entities.User>,RepositoryAbstracts.IUsersRepository
     {
      
       
        public UsersRepository(): base("name=DbconnectionString") { }
        public List<Entities.User> GetById(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Users] WHERE [Id] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.User> GetByUsername(string value) 
        {
             return Runquery("SELECT * FROM[dbo].[Users] WHERE [Username] LIKE @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.User> GetByDate(object value) 
        {
             return Runquery("SELECT * FROM[dbo].[Users] WHERE [Date] = @Value",new SqlParameter("Value", value)); 
         }

   
    }
}
