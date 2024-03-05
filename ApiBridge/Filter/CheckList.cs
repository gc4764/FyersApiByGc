using ApiBridge.Context;
using GCLibrary.Logger;

namespace ApiBridge.Filter
{
    internal class CheckList
    {
     

        public CheckList(UserContext userContext, ILogger logger, RequestMessageContext cmd)
        {
            UserContext = userContext;
            Logger = logger;
            Cmd = cmd;
        }

        public UserContext UserContext { get; }
        public RequestMessageContext Cmd { get; }
        public ILogger Logger { get; }

        public bool Validate()
        {
            return true;
        }
    }
}