using Autofac;
using Autofac.Extras.DynamicProxy;
using TestOfClaudeGen.Core.User.Jobs.Posts;
using X.Proto.Common.ServiceConnector;

namespace TestOfClaudeGen.Core.User.Jobs
{
    /// <summary>
    /// Autofac registration module for the Core.User.Jobs use case
    /// (including the «include»d Core.User.Job.Posts objects from the Posts folder).
    /// Each component is registered as a named IXConnector so XServiceConnector can resolve it by name.
    /// </summary>
    public class RUserJobs : Module
    {
        protected override void Load( ContainerBuilder builder )
        {
            // composite + aggregation: two tables -> 5-param constructor
            builder.RegisterType<UserJobs>()
                   .Named<IXConnector>( "IUserJobs" )
                   .SingleInstance()
                   .WithParameter( "pFieldComposit", "jobs" )
                   .WithParameter( "pTableComposit", "usr.user_jobs_cmps" )
                   .WithParameter( "pTableAgregate", "usr.user_jobs_aggr" )
                   .WithParameter( "pConnectionName", null )
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

            // composite only: one table -> 4-param constructor
            builder.RegisterType<UserJobPosts>()
                   .Named<IXConnector>( "IUserJobPosts" )
                   .SingleInstance()
                   .WithParameter( "pFieldComposit", "jobs" )
                   .WithParameter( "pTableComposit", "usr.user_job_posts_cmps" )
                   .WithParameter( "pConnectionName", null )
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );
        }
    }
}
