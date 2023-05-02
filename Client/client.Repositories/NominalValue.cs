using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Client.Repositories
{
      public class NominalValueRepository : DataLayer.GenericRepository<Entities.NominalValue>,RepositoryAbstracts.INominalValueRepository
     {
        public NominalValueRepository(): base("name=DbconnectionString") { }
        public List<Entities.NominalValue> GetByTypeId(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[NominalValue] WHERE [TypeId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.NominalValue> GetByNominalId(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[NominalValue] WHERE [NominalId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.NominalValue> GetByValue(float value) 
        {
             return Runquery("SELECT * FROM[dbo].[NominalValue] WHERE [Value] = @Value",new SqlParameter("Value", value)); 
         }
     }
}
