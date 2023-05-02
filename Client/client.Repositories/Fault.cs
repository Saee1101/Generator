using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Client.Repositories
{
      public class FaultsRepository : DataLayer.GenericRepository<Entities.Fault>,RepositoryAbstracts.IFaultsRepository
     {
        public FaultsRepository(): base("name=DbconnectionString") { }
        public List<Entities.Fault> GetById(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Faults] WHERE [Id] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Fault> GetByTypeId(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Faults] WHERE [TypeId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Fault> GetByModeId(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Faults] WHERE [ModeId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Fault> GetByNominalId(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Faults] WHERE [NominalId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Fault> GetByDate(DateTime value) 
        {
             return Runquery("SELECT * FROM[dbo].[Faults] WHERE [Date] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Fault> GetByValue(float value) 
        {
             return Runquery("SELECT * FROM[dbo].[Faults] WHERE [Value] = @Value",new SqlParameter("Value", value)); 
         }
     }
}
