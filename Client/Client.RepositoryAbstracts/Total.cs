using System;
using System.Collections.Generic;

namespace Client.RepositoryAbstracts
{
      public interface ITotalRepository : DataLayer.IRepository<Entities.Total>
     {
        List<Entities.Total> GetById(int value) ;
        List<Entities.Total> GetByTypeId(int value) ;
        List<Entities.Total> GetByModeId(int value) ;
        List<Entities.Total> GetByOnDate(DateTime value) ;
        List<Entities.Total> GetByOffDate(DateTime value) ;
        List<Entities.Total> GetBySum(long? value) ;
     }
}
