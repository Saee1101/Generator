using System;
using System.Collections.Generic;

namespace Client.RepositoryAbstracts
{
      public interface ITypeRepository : DataLayer.IRepository<Entities.Type>
     {
        List<Entities.Type> GetById(int value) ;
        List<Entities.Type> GetByParentTypeId(int value) ;
        List<Entities.Type> GetByTitle(string value) ;
     }
}
