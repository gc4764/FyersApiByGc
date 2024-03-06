using ApiBridge.Context;
using GCLibrary.Logger;

namespace ApiBridge.Filter
{
    internal class CheckBlackList
    {
        private UserContext userContext;
        private ILogger logger;
        private RequestMessageContext cmd;

        public CheckBlackList(UserContext userContext, ILogger logger, RequestMessageContext cmd)
        {
            this.userContext = userContext;
            this.logger = logger;
            this.cmd = cmd;
        }

        internal bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}