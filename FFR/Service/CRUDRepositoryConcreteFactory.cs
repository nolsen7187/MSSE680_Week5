using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Service
{
    public abstract class CRUDRepositoryConcreteFactory
    {
        public static DataRepository<T> CRUD<T>() where T : class
        {
            DataRepository<T> modifiedRepository = Activator.CreateInstance<DataRepository<T>>();
            return modifiedRepository;
        }

    }
}