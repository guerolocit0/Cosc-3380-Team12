/*
DATE: 3/16/2019
DESCRIPTION: This query displays metadata for the purpose of verifying that the database has been loaded into the DBMS
*/
SELECT table_name, column_name, column_type, is_nullable, column_key
FROM information_schema.columns
WHERE table_schema = 'zoo'
ORDER BY table_name, ordinal_position
