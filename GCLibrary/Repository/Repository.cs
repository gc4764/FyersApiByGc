using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Repository
{
    public class Repository : IRepository
    {
        void IRepository.Delete<ModelType>(ModelType type)
        {
            throw new NotImplementedException();
        }

        void IRepository.Insert<ModelType>(ModelType type)
        {
            throw new NotImplementedException();
        }

        bool IRepository.IsInTable<ModelType>(ModelType type)
        {
            throw new NotImplementedException();
        }

        ResultSet IRepository.Select<ModelType, ResultSet>(ModelType type)
        {
            throw new NotImplementedException();
        }

        void IRepository.Update<ModelType>(ModelType type)
        {
            throw new NotImplementedException();
        }
    }
}
