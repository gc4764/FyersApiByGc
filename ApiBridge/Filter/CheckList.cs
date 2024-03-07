using ApiBridge.Context;
using GCLibrary.Logger;
using GCLibrary.Interfaces;

namespace ApiBridge.Filter
{
    public class CheckList(UserContext userContext, ILogger logger, IRequestMessageContext cmd)
    {
        private readonly UserContext _userContext = userContext;
        private readonly ILogger _logger = logger;
        private readonly IRequestMessageContext _cmd = cmd;

        public bool Validate()
        {
            CheckWhiteList checkWhiteList = new(_userContext, _logger, _cmd);
            if(checkWhiteList.Validate())
            {
                CheckBlackList checkBlackList = new(_userContext, _logger, _cmd);
                if(checkBlackList.Validate())
                {
                    return true;
                }
                return false;
            }
            return true;
        }
    }
}