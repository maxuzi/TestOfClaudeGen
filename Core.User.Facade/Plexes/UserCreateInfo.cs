using X.Proto.Common.Data;
using X.Proto.Common.Endpoints.Invoker;

namespace TestOfClaudeGen.Core.User.Facade.Plexes
{
    /// <summary>
    /// UML: Core.User.Facade page — UserCreateInfo «named» : UserCreateBase
    /// </summary>
    public class UserCreateInfo : UserCreateBase
    {
        public UserCreateInfo( IXInvoker pInvoker ) : base( pInvoker )
        {
        }

        public override Task RunTask( XData pParams ) => throw new NotImplementedException();
    }
}
