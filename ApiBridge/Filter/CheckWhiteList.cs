using ApiBridge.Context;
using GCLibrary.Logger;
using GCLibrary.Interfaces;

namespace ApiBridge.Filter
{
    internal class CheckWhiteList
    {
        private UserContext _userContext;
        private ILogger _logger;
        private IRequestMessageContext _cmd;

        public CheckWhiteList(UserContext userContext, ILogger logger, IRequestMessageContext cmd)
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