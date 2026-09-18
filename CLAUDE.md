# Project: TestOfClaudeGen

Inherits all global rules from d:\WORK\CLAUDE.md.

## What this project is
- A training solution for generating X.Proto-based solutions from a draw.io UML.
- The single source of structure is `UML.html` in this folder (a copy of the one in X.Proto_ML_Skills). Classes are changed only through the UML.

## Project-specific rules
- Generate strictly from `UML.html` + `X.Proto.Framework.v5\!docs\X.Proto_ML_Skills`. Do not look at TutorialDemoProject.
- Solution folders (virtual): Applications { Core, Endpoints, MigrationsDb, ReferenceEntities }, Debug, iOutsideApplications, LIB { X.Proto }.
- On disk all projects live flat in the solution root: `D:\WORK\TestOfClaudeGen\<ProjectName>\`.
- AssemblyName / RootNamespace of an application project = `TestOfClaudeGen.<UseCaseName>`.
- Framework projects are referenced by relative path `..\..\X.Proto.Framework.v5\<Project>\<Project>.csproj` and grouped under LIB\X.Proto.

## Modules / microservices
- **Core.User** (use case UC01 → Crud template): `IUser : IXCrudComponent`, `User : XCrudComponent`, Autofac module `RUser` registers `Named<IXConnector>("IUser")` on table `usr.user`.
- **MigrationsDb.pg_001_usr** (DbUp, postgres): schema `usr`, table `usr.user` (`XPK_user` on id INCLUDE name, `XUK_account`).
- **MigrationsDb.pg_000_sys**: framework system-schema migrations, linked from X.Proto.Framework.v5.
