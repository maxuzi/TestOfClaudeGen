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
- **Core.User.Jobs** (use case → MasterDetails template): `IUserJobs : IXMasterDetail`, `UserJobs : XMasterDetail` (5-param ctor: composite + aggregate tables), Autofac module `RUserJobs` registers `Named<IXConnector>("IUserJobs")` with `pFieldComposit="jobs"`, `pTableComposit="usr.user_jobs_cmps"`, `pTableAgregate="usr.user_jobs_aggr"`.
  - **Posts** folder = the `<<include>>`d use case Core.User.Job.Posts: `IUserJobPosts : IXMasterDetail`, `UserJobPosts : XMasterDetail` (4-param ctor: composite only), registered in the same `RUserJobs` as `Named<IXConnector>("IUserJobPosts")` on `usr.user_job_posts_cmps`.
- **MigrationsDb.pg_001_usr** (DbUp, postgres): schema `usr`; `001_usr_CT_user.sql` → `usr.user` (`XPK_user` on id INCLUDE name, `XUK_account`); `0040_usr_CT_user_jobs.sql` → `usr.user_jobs_cmps` + `usr.user_jobs_aggr`; `0060_usr_CT_user_job_post.sql` → `usr.user_job_posts_cmps`. After first generation the .sql files are primary, the UML «table» elements are secondary.
- **MigrationsDb.pg_000_sys**: framework system-schema migrations, linked from X.Proto.Framework.v5.
