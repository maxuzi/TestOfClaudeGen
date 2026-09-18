using X.Proto.Db.Api;
using X.Proto.Db.Component.MasterDetails;

namespace TestOfClaudeGen.Core.User.Jobs
{
    /// <summary>
    /// UML: Core.User.Jobs page — «class» UserJobs : XMasterDetail, IUserJobs
    /// MasterDetail with BOTH composite and aggregation relations (5-param constructor):
    ///   composite table  usr.user_jobs_cmps «table-cmps» (user_id «XPK», jobs JSONB)
    ///   aggregate table  usr.user_jobs_aggr «table-aggr» (job_id «XPK», user_id, job_type, name)
    /// See MigrationsDb.pg_001_usr\Scripts\0040_usr_CT_user_jobs.sql
    /// </summary>
    public class UserJobs : XMasterDetail, IUserJobs
    {
        public UserJobs( IXDbApi pDbExecuter, string pFieldComposit, string pTableComposit, string pTableAgregate, string pConnectionName )
            : base( pDbExecuter, pFieldComposit, pTableComposit, pTableAgregate, pConnectionName )
        {
        }
    }
}
