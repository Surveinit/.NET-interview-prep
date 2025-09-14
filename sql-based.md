// Menu: todo.md

// []- Dbms vs rdbms
-
- A DBMS is any system that manages and organizes data,
- whereas RDBMS is a type of DBMS where data is organized in tables and relationships.
- For eg; A file system is a DBMS, but MySQL and SQL servers are RDBMS.


// []- Sql vs mysql
-
- SQL (Stuctured query language) is a language used to query and manage relational database. It defines how you create, read, update, delete data.
- MySQL is a Relational Database Management System that uses SQL as its query lanaguage.
- In simple terms SQL is the language, and MySQL is the tool that uses that language to perform tasks.


// []- DDL, DML bullshit
-
- Data Definition Language deals with structure/scheme of the db.
- CREATE, ALTER, DROP, TRUNCATE

- Data Manipulation Language deals with actual data.
- SELECT, INSERT, UPDATE, DELETE

- Data Control Language deals with access to the db.
- GRANT, REVOKE


// []- Sql joins
-
- LEFT JOIN returns all records from the left & matching records from the right.
- RIGHT JOIN returns all records from the right & matching records from the left.
- INNER JOIN returns only matching records from both tables.


// []- SQL join, top 5 salaries.
- 
- 
SELECT e.Name, d.DepartmentName
FROM Employees e
INNER JOIN Departments d ON e.DeptId = d.DeptId;

- 
SELECT DISTINCT Salary
FROM Employees
ORDER BY Salary DESC
LIMIT 5;


// []- table salary summary
- 
- To get a Salary summary we'll use Aggregators such as SUM for total salary spend by the company, AVG for average salary of our Employees, MAX/MIN from highest and lowest paid employee.


// []- How to write procedures
- 
- A stored procedure is a set of SQL statements stored in the DB and executed as a program.
- CREATE PROCEDURE procedure_name(parameters)
BEGIN
 -- SQL statements
END 
