using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Client.Repositories
{
      public class Type_UnitsRepository : DataLayer.GenericRepository<Entities.Type_Unit>,RepositoryAbstracts.IType_UnitsRepository
     {
        public Type_UnitsRepository(): base("name=DbconnectionString") { }
        public List<Entities.Type_Unit> GetById(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Type_Units] WHERE [Id] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Type_Unit> GetByTitle(string value) 
        {
             return Runquery("SELECT * FROM[dbo].[Type_Units] WHERE [Title] LIKE @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Type_Unit> GetByDESCRIPTION(string value) 
        {
             return Runquery("SELECT * FROM[dbo].[Type_Units] WHERE [DESCRIPTION] LIKE @Value",new SqlParameter("Value", value)); 
         }
     }
}
