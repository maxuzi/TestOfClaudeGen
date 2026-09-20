# Project: TestOfClaudeGen

Inherits all global rules from d:\WORK\CLAUDE.md.

## What this project is
- A training solution for generating X.Proto-based solutions from a draw.io UML.
- The single source of structure is `UML.html` in this folder (a copy of the one in X.Proto_ML_Skills). Classes are changed only through the UML.

## Project-specific rules
- Generate strictly from `UML.html` + `X.Proto.Framework.v5\!docs\X.Proto_ML_Skills`. Do not look at TutorialDemoProject.
- Do not list the skills folder recursively (it would expose the tutorial file names); list only `StageApplications` and `StageEndpoints`.
- The only allowed look into TutorialDemoProject is when a skills doc says **"go to xxx.cs"**: open that one file, treat it as the template and reproduce by analogy.
- The framework source itself (X.Proto.* projects, MigrationsDb.pg_000_sys) may be read to resolve APIs and constructor parameters.
- `UML.html` is a draw.io HTML export: decode the `data-mxgraph` attribute (HtmlDecode -> JSON -> `xml`) with PowerShell. Pages: `UseCases` (id UC) + one class page per use case. Stereotypes: «XPK» primary key, `<<INCLUDE>>` include into PK, «XUK» unique, «table» / «table-cmps» / «table-aggr». A use-case `<<include>>` edge = sub-folder inside the parent project, not a new project.
- Solution folders (virtual): Applications { Core, Endpoints, MigrationsDb, ReferenceEntities }, Debug, iOutsideApplications, LIB { X.Proto }.
- On disk all projects live flat in the solution root: `D:\WORK\TestOfClaudeGen\<ProjectName>\`.
- AssemblyName / RootNamespace of an application project = `TestOfClaudeGen.<UseCaseName>`.
- Framework projects are referenced by relative path `..\..\X.Proto.Framework.v5\<Project>\<Project>.csproj` and grouped under LIB\X.Proto.
- Git: `feature/claude` in X.Proto.Framework.v5 is the "claude" branch; never commit or push. TestOfClaudeGen itself is not a git repo.
- Mak maintains the «table» links in UML and renames .sql scripts himself; treat renamed files as new names.
- After every generation pass: `dotnet build TestOfClaudeGen.sln` must be clean, then report which gaps in the skills docs were filled from the framework (that feedback is the point of the experiment).

## Session memory
- This file is the persistent memory for TestOfClaudeGen. Update the **Modules** section after each generation pass so a new session can continue without re-discovery.
- Claude auto-memory is keyed by the session working directory; sessions opened in `D:\WORK\X.Proto.Framework.v5` and in `D:\WORK\TestOfClaudeGen` have separate memory folders. Rely on this file, not on auto-memory.

## Modules / microservices
- **Core.User** (use case UC01 → Crud template): `IUser : IXCrudComponent`, `User : XCrudComponent`, Autofac module `RUser` registers `Named<IXConnector>("IUser")` on table `usr.user`.
- **Core.User.Jobs** (use case → MasterDetails template): `IUserJobs : IXMasterDetail`, `UserJobs : XMasterDetail` (5-param ctor: composite + aggregate tables), Autofac module `RUserJobs` registers `Named<IXConnector>("IUserJobs")` with `pFieldComposit="jobs"`, `pTableComposit="usr.user_jobs_cmps"`, `pTableAgregate="usr.user_jobs_aggr"`.
  - **Posts** folder = the `<<include>>`d use case Core.User.Job.Posts: `IUserJobPosts : IXMasterDetail`, `UserJobPosts : XMasterDetail` (4-param ctor: composite only), registered in the same `RUserJobs` as `Named<IXConnector>("IUserJobPosts")` on `usr.user_job_posts_cmps`.
- **MigrationsDb.pg_001_usr** (DbUp, postgres): schema `usr`; `001_usr_CT_user.sql` → `usr.user` (`XPK_user` on id INCLUDE name, `XUK_account`); `0040_usr_CT_user_jobs.sql` → `usr.user_jobs_cmps` + `usr.user_jobs_aggr`; `0060_usr_CT_user_job_post.sql` → `usr.user_job_posts_cmps`. After first generation the .sql files are primary, the UML «table» elements are secondary.
- **MigrationsDb.pg_000_sys**: framework system-schema migrations, linked from X.Proto.Framework.v5.
