using System;
using System.Collections.Generic;

namespace Client.RepositoryAbstracts
{
      public interface IType_UnitsRepository : DataLayer.IRepository<Entities.Type_Unit>
     {
        List<Entities.Type_Unit> GetById(int value) ;
        List<Entities.Type_Unit> GetByTitle(string value) ;
        List<Entities.Type_Unit> GetByDESCRIPTION(string value) ;
     }
}
