using X.Proto.Db.Api;
using X.Proto.Db.Component.MasterDetails;

namespace TestOfClaudeGen.Core.User.Jobs.Posts
{
    /// <summary>
    /// UML: Core.User.Job.Posts page — «class» UserJobPosts : XMasterDetail, IUserJobPosts
    /// MasterDetail with ONLY the composite relation (4-param constructor):
    ///   composite table usr.user_job_posts_cmps «table-cmps» (user_id «XPK», jobs JSONB)
    /// See MigrationsDb.pg_001_usr\Scripts\0060_usr_CT_user_job_post.sql
    /// </summary>
    public class UserJobPosts : XMasterDetail, IUserJobPosts
    {
        public UserJobPosts( IXDbApi pDbExecuter, string pFieldComposit, string pTableComposit, string pConnectionName )
            : base( pDbExecuter, pFieldComposit, pTableComposit, pConnectionName )
        {
        }
    }
}
