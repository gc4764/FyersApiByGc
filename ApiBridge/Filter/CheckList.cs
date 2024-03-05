using ApiBridge.Context;

namespace ApiBridge.Filter
{
    internal class CheckList
    {
        public CheckList(UserContext userContext, RequestMessageContext cmd)
        {
            UserContext = userContext;
            Cmd = cmd;
        }

        public UserContext UserContext { get; }
        public RequestMessageContext Cmd { get; }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}