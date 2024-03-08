using ApiBridge.Context;
using GCLibrary.Logger;
using GCLibrary.Filter;
using GCLibrary.Context;

namespace ApiBridge.Filter
{
    internal class WhiteListFilter : IFilter, IBrokerContextConsumer, IUserContext, IRequestMessageContextProducer
    {
        public IBrokerContextConsumer BrokerContext { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IUserContext UserContext { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OrderType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Response RunFilter()
        {
            throw new NotImplementedException();
        }
    }
}