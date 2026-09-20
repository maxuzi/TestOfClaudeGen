using X.Proto.Db.Api;
using X.Proto.Db.Component.ManyToMany;

namespace TestOfClaudeGen.Core.BT.Calc.EmployeeCountry
{
    /// <summary>
    /// UML: Core.BT.Calc.Employee_Country page — «class» Employee_Country : XManyToManyComponent, IEmployee_Country
    /// Backed by table clc.employee__country (see MigrationsDb.pg_002_clc).
    /// Reached from Core.BT.Calc via an &lt;&lt;include&gt;&gt; edge on the UseCases
    /// page, so it lives as a subfolder of Core.BT.Calc rather than its own project.
    /// </summary>
    public class Employee_Country : XManyToManyComponent, IEmployee_Country
    {
        public Employee_Country( IXDbApi pDbExecuter, string pTableName, string pConnectionName )
            : base( pDbExecuter, pTableName, pConnectionName )
        {
        }
    }
}
