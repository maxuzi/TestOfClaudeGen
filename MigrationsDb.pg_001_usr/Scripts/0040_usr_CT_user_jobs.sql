-- UML: Core.User.Jobs page — MasterDetail with composite AND aggregation relations (two tables)
--
-- usr.user_jobs_cmps «table-cmps»  (master row; details accumulated into the JSONB history field)
--   + user_id: TIMESTAMP   «XPK»
--   + jobs:    JSONB
CREATE TABLE IF NOT EXISTS usr.user_jobs_cmps (
   user_id   TIMESTAMP
  ,jobs      JSONB
);

ALTER TABLE usr.user_jobs_cmps ADD CONSTRAINT XPK_user_jobs_cmps PRIMARY KEY ( user_id );

-- usr.user_jobs_aggr «table-aggr»  (flat copy of every detail row)
--   + job_id:   TIMESTAMP   «XPK»
--   + user_id:  TIMESTAMP
--   + job_type: TEXT
--   + name:     TEXT
CREATE TABLE IF NOT EXISTS usr.user_jobs_aggr (
   job_id    TIMESTAMP
  ,user_id   TIMESTAMP
  ,job_type  TEXT
  ,name      TEXT
);

ALTER TABLE usr.user_jobs_aggr ADD CONSTRAINT XPK_user_jobs_aggr PRIMARY KEY ( job_id );
