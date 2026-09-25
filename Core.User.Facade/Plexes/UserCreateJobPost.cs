using X.Proto.Common.Data;
using X.Proto.Common.Endpoints.Invoker;

namespace TestOfClaudeGen.Core.User.Facade.Plexes
{
    /// <summary>
    /// UML: Core.User.Facade page — UserCreateJobPost «named» : UserCreateBase
    /// </summary>
    public class UserCreateJobPost : UserCreateBase
    {
        public UserCreateJobPost( IXInvoker pInvoker ) : base( pInvoker )
        {
        }

        public override Task RunTask( XData pParams ) => throw new NotImplementedException();
    }
}
