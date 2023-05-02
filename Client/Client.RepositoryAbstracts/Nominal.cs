using System;
using System.Collections.Generic;

namespace Client.RepositoryAbstracts
{
      public interface INominalRepository : DataLayer.IRepository<Entities.Nominal>
     {
        List<Entities.Nominal> GetById(int value) ;
        List<Entities.Nominal> GetByModelId(int value) ;
        List<Entities.Nominal> GetByKey(string value) ;
        List<Entities.Nominal> GetByTitel(string value) ;
        List<Entities.Nominal> GetByTel(float? value) ;
        List<Entities.Nominal> GetByTel_(float? value) ;
     }
}
