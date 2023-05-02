using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Client.Repositories
{
      public class NominalRepository : DataLayer.GenericRepository<Entities.Nominal>,RepositoryAbstracts.INominalRepository
     {
        public NominalRepository(): base("name=DbconnectionString") { }
        public List<Entities.Nominal> GetById(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Nominal] WHERE [Id] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Nominal> GetByModelId(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Nominal] WHERE [ModelId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Nominal> GetByKey(string value) 
        {
             return Runquery("SELECT * FROM[dbo].[Nominal] WHERE [Key] LIKE @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Nominal> GetByTitel(string value) 
        {
             return Runquery("SELECT * FROM[dbo].[Nominal] WHERE [Titel] LIKE @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Nominal> GetByTel(float? value) 
        {
             return Runquery("SELECT * FROM[dbo].[Nominal] WHERE [Tel+] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Nominal> GetByTel_(float? value) 
        {
             return Runquery("SELECT * FROM[dbo].[Nominal] WHERE [Tel-] = @Value",new SqlParameter("Value", value)); 
         }
     }
}
