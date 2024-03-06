using ApiBridge.Context;
using GCLibrary.Logger;

namespace ApiBridge.Filter
{
    public class CheckList(UserContext userContext, ILogger logger, RequestMessageContext cmd)
    {
        private readonly UserContext _userContext = userContext;
        private readonly ILogger _logger = logger;
        private readonly RequestMessageContext _cmd = cmd;

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