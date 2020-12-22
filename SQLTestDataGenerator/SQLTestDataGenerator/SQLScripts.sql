--sql server

--select all tables
SELECT TABLE_NAME FROM information_schema.tables
where TABLE_TYPE = 'BASE TABLE';

--select all tables that has no fkey
SELECT tbl.name
FROM sys.tables AS tbl
    LEFT JOIN sys.foreign_key_columns AS fKey
    ON tbl.object_id = fKey.parent_object_id
WHERE fKey.parent_object_id IS NULL


--select all tables that has a foreign key

SELECT TABLE_NAME FROM information_schema.tables
where TABLE_TYPE = 'BASE TABLE' and TABLE_NAME not in (
	SELECT tbl.name
	FROM sys.tables AS tbl
		LEFT JOIN sys.foreign_key_columns AS fKey
		ON tbl.object_id = fKey.parent_object_id
	WHERE fKey.parent_object_id IS NULL
);


--select all tables and its fk
select TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE from INFORMATION_SCHEMA.TABLE_CONSTRAINTS
where CONSTRAINT_TYPE = 'FOREIGN KEY'

------------------------------------------------------------------------------
