using System;
using System.Collections.Generic;

namespace Client.RepositoryAbstracts
{
      public interface IUsersRepository : DataLayer.IRepository<Entities.User>
     {
        List<Entities.User> GetById(int value) ;
        List<Entities.User> GetByUsername(string value) ;
        List<Entities.User> GetByDate(object value) ;
    
    }
}
