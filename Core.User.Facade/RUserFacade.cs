using Autofac;
using Autofac.Extras.DynamicProxy;
using X.Proto.Common.ServiceConnector;

namespace TestOfClaudeGen.Core.User.Facade
{
    /// <summary>
    /// Autofac registration module for the Core.User.Facade use case.
    /// </summary>
    public class RUserFacade : Module
    {
        protected override void Load( ContainerBuilder builder )
        {
            builder.RegisterType<UserFacade>()
                   .Named<IXConnector>( "IUserFacade" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );
        }
    }
}
