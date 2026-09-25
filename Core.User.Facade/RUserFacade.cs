using Autofac;
using Autofac.Extras.DynamicProxy;
using TestOfClaudeGen.Core.User.Facade.Plexes;
using X.Proto.Common.ServiceConnector;
using X.Proto.Component.Patterns.Multiplexor;

namespace TestOfClaudeGen.Core.User.Facade
{
    /// <summary>
    /// Autofac registration module for the Core.User.Facade use case, including the
    /// XTaskPlexBase classes UserFacade's multiplexor field drives (resolved by
    /// class name — see XMultiplexor.RunTasks).
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

            builder.RegisterType<UserCreateInfo>()
                   .Named<XTaskPlexBase>( "UserCreateInfo" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<UserCreateJobs>()
                   .Named<XTaskPlexBase>( "UserCreateJobs" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            builder.RegisterType<UserCreateJobPost>()
                   .Named<XTaskPlexBase>( "UserCreateJobPost" )
                   .SingleInstance()
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );
        }
    }
}
