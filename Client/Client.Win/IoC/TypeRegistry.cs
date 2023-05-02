using Client.Repositories;
using Client.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Win.IoC
{
    class TypeRegistry : StructureMap.Registry
    {
        public TypeRegistry()
        {
            For<IUsersRepository>().Use<UsersRepository>();
            For<IDbTools>().Use<SqlDbTools>();
            
        }
    }
}
