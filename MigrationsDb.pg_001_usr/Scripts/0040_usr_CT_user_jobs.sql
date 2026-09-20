-- UML: Core.User.Jobs page
--   usr.user_jobs_cmps «table-cmps»: user_id TIMESTAMP «XPK», jobs JSONB
--   usr.user_jobs_aggr «table-aggr»: job_id TIMESTAMP «XPK», user_id TIMESTAMP, job_type TEXT, name TEXT
CREATE TABLE IF NOT EXISTS usr.user_jobs_cmps (
   user_id   TIMESTAMP
  ,jobs      JSONB
);

ALTER TABLE usr.user_jobs_cmps ADD CONSTRAINT XPK_user_jobs_cmps PRIMARY KEY ( user_id );

CREATE TABLE IF NOT EXISTS usr.user_jobs_aggr (
   job_id    TIMESTAMP
  ,user_id   TIMESTAMP
  ,job_type  TEXT
  ,name      TEXT
);

ALTER TABLE usr.user_jobs_aggr ADD CONSTRAINT XPK_user_jobs_aggr PRIMARY KEY ( job_id );
