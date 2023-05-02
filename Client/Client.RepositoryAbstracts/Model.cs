using System;
using System.Collections.Generic;

namespace Client.RepositoryAbstracts
{
      public interface IModelRepository : DataLayer.IRepository<Entities.Model>
     {
        List<Entities.Model> GetById(int value) ;
        List<Entities.Model> GetByTypeId(int? value) ;
        List<Entities.Model> GetByTitle(string value) ;
        List<Entities.Model> GetByCode(string value) ;
     }
}
