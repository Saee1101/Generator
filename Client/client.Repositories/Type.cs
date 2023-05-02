using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Client.Repositories
{
      public class TypeRepository : DataLayer.GenericRepository<Entities.Type>,RepositoryAbstracts.ITypeRepository
     {
        public TypeRepository(): base("name=DbconnectionString") { }
        public List<Entities.Type> GetById(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Type] WHERE [Id] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Type> GetByParentTypeId(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Type] WHERE [ParentTypeId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Type> GetByTitle(string value) 
        {
             return Runquery("SELECT * FROM[dbo].[Type] WHERE [Title] LIKE @Value",new SqlParameter("Value", value)); 
         }
     }
}
