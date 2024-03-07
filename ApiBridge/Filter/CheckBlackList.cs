using ApiBridge.Context;
using GCLibrary.Logger;
using GCLibrary.Interfaces;
using GCLibrary.Filter;

namespace ApiBridge.Filter
{
    internal class CheckBlackList : IFilter
    {
        private UserContext userContext;
        private ILogger logger;
        private IRequestMessageContext cmd;

        public CheckBlackList(UserContext userContext, ILogger logger, IRequestMessageContext cmd)
        {
            this.userContext = userContext;
            this.logger = logger;
            this.cmd = cmd;
        }

        public FilterResponse Result => throw new NotImplementedException();

        public FilterResponse RunFilter()
        {
            throw new NotImplementedException();
        }
    }
}