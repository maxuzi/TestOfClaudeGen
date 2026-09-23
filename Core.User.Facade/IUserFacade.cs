using X.Proto.Common.Data;
using X.Proto.Common.ServiceConnector;

namespace TestOfClaudeGen.Core.User.Facade
{
    /// <summary>
    /// UML: Core.User.Facade page — «interface» IUserFacade : IXConnector
    /// </summary>
    public interface IUserFacade : IXConnector
    {
        Task<XData> Create( XData pUserData );
    }
}
