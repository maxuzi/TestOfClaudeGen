-- UML: Core.User page — usr.user «table»
--   + id: TIMESTAMP    «XPK» (INCLUDE name)
--   + name: TEXT        <<INCLUDE>>
--   + account: TEXT     «XUK»
CREATE TABLE IF NOT EXISTS usr.user (
   id        TIMESTAMP
  ,name      TEXT
  ,account   TEXT
);

ALTER TABLE usr.user ADD CONSTRAINT XPK_user PRIMARY KEY ( id ) INCLUDE ( name );

ALTER TABLE usr.user ADD CONSTRAINT XUK_account UNIQUE ( account );
