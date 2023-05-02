using System;
using System.Collections.Generic;

namespace Client.RepositoryAbstracts
{
      public interface IFaultsRepository : DataLayer.IRepository<Entities.Fault>
     {
        List<Entities.Fault> GetById(int value) ;
        List<Entities.Fault> GetByTypeId(int value) ;
        List<Entities.Fault> GetByModeId(int value) ;
        List<Entities.Fault> GetByNominalId(int value) ;
        List<Entities.Fault> GetByDate(DateTime value) ;
        List<Entities.Fault> GetByValue(float value) ;
     }
}
