using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Repository
{
    public interface IRepositoryAsync
    {

        void InsertAsync<ModelType>(ModelType type);
        void UpdateAsync<ModelType>(ModelType type);
        void DeleteAsync<ModelType>(ModelType type);

        ModelType SelectAsync<ModelType>(ModelType type);

        bool IsInTableAsync<ModelType>(ModelType type);
    }
}
