using X.Proto.Db.Api;
using X.Proto.Db.Component.Crud;

namespace TestOfClaudeGen.Core.User
{
    /// <summary>
    /// UML: Core.User page — «class» User : XCrudComponent, IUser
    /// Backed by table usr.user (see MigrationsDb.pg_001_usr).
    /// </summary>
    public class User : XCrudComponent, IUser
    {
        public User( IXDbApi pDbExecuter, string pTableName, string pConnectionName )
            : base( pDbExecuter, pTableName, pConnectionName )
        {
        }
    }
}
