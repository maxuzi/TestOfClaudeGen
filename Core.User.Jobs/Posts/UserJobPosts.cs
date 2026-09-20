using X.Proto.Db.Api;
using X.Proto.Db.Component.MasterDetails;

namespace TestOfClaudeGen.Core.User.Jobs.Posts
{
    /// <summary>
    /// UML: Core.User.Job.Posts page — «class» UserJobPosts : XMasterDetail, IUserJobPosts
    /// Backed by usr.user_job_posts_cmps («table-cmps») only — no aggregate table shown,
    /// so the 4-param ctor applies.
    /// </summary>
    public class UserJobPosts : XMasterDetail, IUserJobPosts
    {
        public UserJobPosts( IXDbApi pDbExecuter, string pFieldComposit, string pTableComposit, string pConnectionName )
            : base( pDbExecuter, pFieldComposit, pTableComposit, pConnectionName )
        {
        }
    }
}
