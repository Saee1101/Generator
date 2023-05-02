using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Client.Repositories
{
      public class ModelRepository : DataLayer.GenericRepository<Entities.Model>,RepositoryAbstracts.IModelRepository
     {
        public ModelRepository(): base("name=DbconnectionString") { }
        public List<Entities.Model> GetById(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Model] WHERE [Id] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Model> GetByTypeId(int? value) 
        {
             return Runquery("SELECT * FROM[dbo].[Model] WHERE [TypeId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Model> GetByTitle(string value) 
        {
             return Runquery("SELECT * FROM[dbo].[Model] WHERE [Title] LIKE @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Model> GetByCode(string value) 
        {
             return Runquery("SELECT * FROM[dbo].[Model] WHERE [Code] LIKE @Value",new SqlParameter("Value", value)); 
         }
     }
}
