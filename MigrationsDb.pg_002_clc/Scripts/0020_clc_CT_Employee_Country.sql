-- UML: Core.BT.Calc.Employee_Country page — clc.employee__country «table-many»
--   + employee_id: TIMESTAMP   «XUKm1»
--   + country_id:  TIMESTAMP   «XUKm2»
--   + rules:       JSONB
-- XUKm1 / XUKm2 = mirror unique indexes over the two FK columns, per 01_DbObjectsRules.txt.
CREATE TABLE IF NOT EXISTS clc.employee__country (
   employee_id  TIMESTAMP
  ,country_id   TIMESTAMP
  ,rules        JSONB
);

ALTER TABLE clc.employee__country ADD CONSTRAINT XUKm1_employee_country UNIQUE ( employee_id, country_id );
ALTER TABLE clc.employee__country ADD CONSTRAINT XUKm2_country_employee UNIQUE ( country_id, employee_id );
