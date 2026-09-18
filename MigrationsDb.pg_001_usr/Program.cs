using DbUp;

// Connection string: 1st command-line argument, else TESTOFCLAUDEGEN_DB env var, else local default.
var connectionString =
    args.Length > 0 ? args[0]
  : Environment.GetEnvironmentVariable( "TESTOFCLAUDEGEN_DB" )
    ?? "Host=localhost;Port=5432;Database=TestOfClaudeGen;Username=postgres";

var upgrader =
    DeployChanges.To
        .PostgresqlDatabase( connectionString )
        .WithScriptsFromFileSystem( "Scripts" )
        .WithVariablesDisabled()
        .LogToConsole()
        .Build();

var result = upgrader.PerformUpgrade();

if( !result.Successful )
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine( result.Error );
    Console.ResetColor();
    return -1;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine( "Success!" );
Console.ResetColor();
return 0;
