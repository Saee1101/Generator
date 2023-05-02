using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Client.Repositories
{
      public class TotalRepository : DataLayer.GenericRepository<Entities.Total>,RepositoryAbstracts.ITotalRepository
     {
        public TotalRepository(): base("name=DbconnectionString") { }
        public List<Entities.Total> GetById(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Total] WHERE [Id] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Total> GetByTypeId(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Total] WHERE [TypeId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Total> GetByModeId(int value) 
        {
             return Runquery("SELECT * FROM[dbo].[Total] WHERE [ModeId] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Total> GetByOnDate(DateTime value) 
        {
             return Runquery("SELECT * FROM[dbo].[Total] WHERE [OnDate] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Total> GetByOffDate(DateTime value) 
        {
             return Runquery("SELECT * FROM[dbo].[Total] WHERE [OffDate] = @Value",new SqlParameter("Value", value)); 
         }
        public List<Entities.Total> GetBySum(long? value) 
        {
             return Runquery("SELECT * FROM[dbo].[Total] WHERE [Sum] = @Value",new SqlParameter("Value", value)); 
         }
     }
}
