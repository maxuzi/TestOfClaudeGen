-- UML: Core.User.Job.Posts page — MasterDetail with the composite relation only (one table)
--
-- usr.user_job_posts_cmps «table-cmps»
--   + user_id: TIMESTAMP   «XPK»
--   + jobs:    JSONB
CREATE TABLE IF NOT EXISTS usr.user_job_posts_cmps (
   user_id   TIMESTAMP
  ,jobs      JSONB
);

ALTER TABLE usr.user_job_posts_cmps ADD CONSTRAINT XPK_user_job_posts_cmps PRIMARY KEY ( user_id );
