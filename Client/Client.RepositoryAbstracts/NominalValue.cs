using System;
using System.Collections.Generic;

namespace Client.RepositoryAbstracts
{
      public interface INominalValueRepository : DataLayer.IRepository<Entities.NominalValue>
     {
        List<Entities.NominalValue> GetByTypeId(int value) ;
        List<Entities.NominalValue> GetByNominalId(int value) ;
        List<Entities.NominalValue> GetByValue(float value) ;
     }
}
