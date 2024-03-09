using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Interfaces
{
    public interface IRepository
    {
        void Insert<ModelType>(ModelType type);
        void Update<ModelType>(ModelType type);
        void Delete<ModelType>(ModelType type);

        ResultSet Select<ModelType, ResultSet>(ModelType type);

        bool IsInTable<ModelType>(ModelType type);

        
    }
}
