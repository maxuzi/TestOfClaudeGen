using Autofac;
using Autofac.Extras.DynamicProxy;
using X.Proto.Common.ServiceConnector;

namespace TestOfClaudeGen.Core.User
{
    /// <summary>
    /// Autofac registration module for the Core.User use case.
    /// Registered as a named IXConnector so XServiceConnector can resolve it by "IUser".
    /// </summary>
    public class RUser : Module
    {
        protected override void Load( ContainerBuilder builder )
        {
            builder.RegisterType<User>()
                   .Named<IXConnector>( "IUser" )
                   .SingleInstance()
                   .WithParameter( "pTableName", "usr.user" )
                   .WithParameter( "pConnectionName", null )
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );
        }
    }
}
