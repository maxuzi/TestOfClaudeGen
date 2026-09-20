using X.Proto.Db.Api;
using X.Proto.Db.Component.MasterDetails;

namespace TestOfClaudeGen.Core.User.Jobs
{
    /// <summary>
    /// UML: Core.User.Jobs page — «class» UserJobs : XMasterDetail, IUserJobs
    /// Backed by usr.user_jobs_cmps («table-cmps») + usr.user_jobs_aggr («table-aggr»)
    /// (see MigrationsDb.pg_001_usr) — both tables present, so the 5-param ctor applies.
    /// </summary>
    public class UserJobs : XMasterDetail, IUserJobs
    {
        public UserJobs( IXDbApi pDbExecuter, string pFieldComposit, string pTableComposit, string pTableAgregate, string pConnectionName )
            : base( pDbExecuter, pFieldComposit, pTableComposit, pTableAgregate, pConnectionName )
        {
        }
    }
}
