using ApiBridge.Context;
using GCLibrary.Logger;

namespace ApiBridge.Filter
{
    internal class CheckWhiteList
    {
        private UserContext _userContext;
        private ILogger _logger;
        private RequestMessageContext _cmd;

        public CheckWhiteList(UserContext userContext, ILogger logger, RequestMessageContext cmd)
        {
            this._userContext = userContext;
            this._logger = logger;
            this._cmd = cmd;
        }

        internal bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}