using Autofac;
using Autofac.Extras.DynamicProxy;
using TestOfClaudeGen.Core.User.Jobs.Posts;
using X.Proto.Common.ServiceConnector;

namespace TestOfClaudeGen.Core.User.Jobs
{
    /// <summary>
    /// Autofac registration for Core.User.Jobs and its included Posts use case
    /// (per 03_Templates.txt: "a R---.cs must include all classes's registration").
    /// The JSONB composite field is "jobs" on both usr.user_jobs_cmps and
    /// usr.user_job_posts_cmps.
    /// </summary>
    public class RUserJobs : Module
    {
        protected override void Load( ContainerBuilder builder )
        {
            builder.RegisterType<UserJobs>()
                   .Named<IXConnector>( "IUserJobs" )
                   .SingleInstance()
                   .WithParameter( "pFieldComposit", "jobs" )
                   .WithParameter( "pTableComposit", "usr.user_jobs_cmps" )
                   .WithParameter( "pTableAgregate", "usr.user_jobs_aggr" )
                   .WithParameter( "pConnectionName", null )
                   .EnableClassInterceptors()
                   .InterceptedBy( "EVENT" );

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
