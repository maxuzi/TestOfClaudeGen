using X.Proto.Common.Data;
using X.Proto.Common.Endpoints.Invoker;

namespace TestOfClaudeGen.Core.User.Facade
{
    /// <summary>
    /// UML: Core.User.Facade page — «class» UserFacade : IUserFacade
    /// Field "- _invoker: IXInvoker" — a direct-IXConnector class (03_Templates.txt
    /// section 4), dispatching through the invoker rather than a direct project
    /// reference to Core.User.
    /// </summary>
    public class UserFacade : IUserFacade
    {
        private readonly IXInvoker _invoker;

        public UserFacade( IXInvoker pInvoker )
        {
            _invoker = pInvoker;
        }

        public Task<XData> Create( XData pUserData ) => throw new NotImplementedException();
    }
}
