using X.Proto.Common.Endpoints.Invoker;
using X.Proto.Component.Patterns.Multiplexor;

namespace TestOfClaudeGen.Core.User.Facade.Plexes
{
    /// <summary>
    /// UML: Core.User.Facade page — UserCreateBase : XTaskPlexBase
    /// Field "+ invoker: IXInvoker" (protected, per the field access-modifier legend).
    /// No `<<named>>` stereotype and no own RunTask override — abstract base shared
    /// by UserCreateInfo/UserCreateJobs/UserCreateJobPost, same pattern as
    /// BT_CountryBase in Core.BT.Calc/ChainLinks.
    /// </summary>
    public abstract class UserCreateBase : XTaskPlexBase
    {
        protected readonly IXInvoker invoker;

        protected UserCreateBase( IXInvoker pInvoker )
        {
            invoker = pInvoker;
        }
    }
}
