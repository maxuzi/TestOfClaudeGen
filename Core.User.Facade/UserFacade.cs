using X.Proto.Common.Data;
using X.Proto.Component.Patterns.Multiplexor;

namespace TestOfClaudeGen.Core.User.Facade
{
    /// <summary>
    /// UML: Core.User.Facade page — «class» UserFacade : IUserFacade
    /// Field "- _multiplexor: IXMultiplexor" drives the XTaskPlexBase classes in
    /// the Plexes folder (UserCreateInfo, UserCreateJobs, UserCreateJobPost).
    /// The earlier "- _invoker: IXInvoker" field was removed from this page —
    /// removed here too, along with the now-unneeded project reference.
    /// </summary>
    public class UserFacade : IUserFacade
    {
        private readonly IXMultiplexor _multiplexor;

        public UserFacade( IXMultiplexor pMultiplexor )
        {
            _multiplexor = pMultiplexor;
        }

        public Task<XData> Create( XData pUserData ) => throw new NotImplementedException();
    }
}
