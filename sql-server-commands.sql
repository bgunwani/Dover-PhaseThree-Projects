


-- Create New Database named `SampleDB`

	CREATE DATABASE SampleDB

-- Use existing database `SampleDB`

	USE SampleDB

-- Create New Database Table `Department`

	CREATE TABLE Department
	(dept_id int,
	dept_name varchar(20),
	dept_location varchar(20),
	dept_added_date datetime)

-- To see the data in `department` table

	SELECT * FROM Department;

-- To insert sample data in `department` table:

	INSERT INTO Department VALUES(101, 'Sales', 'Chennai', '2020-12-30');
	INSERT INTO Department VALUES(102, 'Development', 'Mumbai', GETDATE());
	INSERT INTO Department VALUES(103, 'Testing', 'Mumbai', GETDATE());
	INSERT INTO Department(dept_id, dept_name, dept_added_date) VALUES(104, 'Admin', GETDATE());

-- To delete specific records from `department` table:

	DELETE FROM Department
	WHERE dept_id = 104;

-- To delete all records from `department` table:

	DELETE FROM Department;

-- To update specific records in `department` table:

	UPDATE Department
	SET dept_location = 'Hyderabad', 
	dept_added_date = '2019-01-01'
	WHERE dept_id = 104

-- To update all records in `department` table:

	UPDATE Department
	SET dept_location = 'Hyderabad', 
	dept_added_date = '2019-01-01'

-- To drop `department` table:

	DROP TABLE Department;

	SELECT * FROM Department;
	
-------------------------------------------------------------------



-- Create New Database Table `Department`

	CREATE TABLE Department
	(dept_id int primary key,
	dept_name varchar(20) not null,
	dept_location varchar(20) check (dept_location IN ('Chennai', 'Hyderabad')),
	dept_added_date datetime default GETDATE());

-- To insert sample data in `department` table:

	INSERT INTO Department VALUES(101, 'Sales', 'Chennai', '2020-12-30');
	INSERT INTO Department VALUES(102, 'Development', 'Chennai', DEFAULT);
	INSERT INTO Department VALUES(103, 'Testing', NULL, DEFAULT);
	INSERT INTO Department(dept_id, dept_name, dept_location) VALUES(104, 'Advertisment', 'Hyderabad');
	
-- To create table named `employee`

	CREATE TABLE Employee
	(emp_id int primary key,
	emp_name varchar(20) not null,
	emp_salary float check (emp_salary >= 5000),
	emp_email varchar(20) unique,
	emp_manager_id int,
	emp_added_date datetime default GETDATE(),
	dept_id int foreign key references Department(dept_id));
	
	INSERT INTO Employee(emp_id, emp_name, emp_salary, emp_email, dept_id)
	VALUES(5001, 'King Kochhar', 10000, 'k@gmail.com', 101);
	INSERT INTO Employee(emp_id, emp_name, emp_salary, emp_email, dept_id)
	VALUES(5002, 'John Smith', 20000, 'js@gmail.com', 101);
	INSERT INTO Employee(emp_id, emp_name, emp_salary, emp_email, dept_id)
	VALUES(5003, 'Jenkin Jambs', 25000, 'jj@gmail.com', 102);
	INSERT INTO Employee(emp_id, emp_name, emp_salary, emp_email, dept_id)
	VALUES(5004, 'Kryal Kims', 22000, 'kk@gmail.com', 102);
	INSERT INTO Employee(emp_id, emp_name, emp_salary, emp_email, dept_id)
	VALUES(5005, 'Sarah Bowling', 35000, 'sb@gmail.com', 103);
	INSERT INTO Employee(emp_id, emp_name, emp_salary, emp_email, dept_id)
	VALUES(5006, 'Sarin Lee', 32000, 'sl@gmail.com', 103);
	INSERT INTO Employee(emp_id, emp_name, emp_salary, emp_email, dept_id)
	VALUES(5007, 'Roger Lee', 15000, 'rl@gmail.com', NULL);
	INSERT INTO Employee(emp_id, emp_name, emp_salary, emp_email, dept_id)
	VALUES(5008, 'Gautam Bhalla', 35000, NULL, NULL);
	
	UPDATE Employee
	SET emp_manager_id = 5001
	WHERE emp_id IN (5002, 5003, 5005, 5007);

	UPDATE Employee
	SET emp_manager_id = 5003
	WHERE emp_id = 5004;

	UPDATE Employee
	SET emp_manager_id = 5005
	WHERE emp_id = 5006;

	SELECT * FROM Employee;
	SELECT * FROM Department;
	
---------------------------------------------------------------------	

USE SampleDB;

SELECT * FROM Employee;
SELECT * FROM Department;

-- Projection: To restrict number of columns

	SELECT emp_name, emp_salary, emp_added_date
	from employee;

-- Selection: To restrict number of rows

	SELECT * FROM employee
	WHERE emp_salary > 30000;

-- Projection and Selection: To restrict number of rows and columns

	SELECT emp_name, emp_salary, emp_added_date
	FROM Employee
	WHERE emp_salary > 30000;

-- Arithmetic Operators

	SELECT emp_id, emp_name, emp_salary, emp_salary * 12 emp_annual_salary
	FROM Employee;

	SELECT emp_id, emp_name, emp_salary, emp_salary * 12 'Annual Salary'
	FROM Employee;

	SELECT emp_id, emp_name, emp_salary, emp_salary * 12 as 'Annual Salary'
	FROM Employee;

-- Logical Operators (AND, OR and NOT)

-- AND (Both Conditions must be satisfied.)

	SELECT * FROM Employee
	WHERE emp_id = 5001 AND emp_salary = 10000;

-- OR (Either one of the condition must be satisfied.)

	SELECT * FROM Employee
	WHERE emp_name = 'King Kochhar' OR emp_name = 'John Smith';

-- NOT (Opposite of condition)

	SELECT * FROM Employee
	WHERE emp_id = 5001 AND NOT emp_salary = 20000;

-- MISC Operators (BETWEEN, IN, IS NULL, LIKE)

	SELECT * FROM Employee
	WHERE emp_id BETWEEN 5002 AND 5005;

	SELECT * FROM Employee
	WHERE emp_id NOT BETWEEN 5002 AND 5005;

	SELECT * FROM Employee
	WHERE emp_added_date NOT BETWEEN '2021-01-01' AND '2021-12-31';

	SELECT * FROM Employee
	WHERE emp_name IN ('King Kochhar', 'John Smith', 'Bhawna Gunwani');

	SELECT * FROM Employee
	WHERE emp_name NOT IN ('King Kochhar', 'John Smith', 'Bhawna Gunwani');

-- Fetch the employees who do not report to any one.

	SELECT * FROM Employee
	WHERE emp_manager_id IS NULL

	SELECT * FROM Employee
	WHERE emp_manager_id IS NOT NULL

-- Write Search Criteria using LIKE

	SELECT * FROM Employee
	WHERE emp_name LIKE 'J%'

	SELECT * FROM Employee
	WHERE emp_name LIKE '%s'

	SELECT * FROM Employee
	WHERE emp_name LIKE '%s%'

	SELECT * FROM Employee
	WHERE emp_name LIKE '_a%'

	SELECT * FROM Employee
	WHERE emp_added_date LIKE '%03%'


-- JOIN Staements: To fetch records from two or more tables.

-- Fetch Employee and Their Departments Name:

	SELECT Employee.emp_name, Employee.emp_salary, Department.dept_name, Department.dept_location
	FROM Employee JOIN Department
	ON Employee.dept_id = Department.dept_id

	SELECT e.emp_name, e.emp_salary, d.dept_name, d.dept_location
	FROM Employee e JOIN Department d
	ON e.dept_id = d.dept_id

	SELECT e.emp_name, e.emp_salary, d.dept_name, d.dept_location
	FROM Employee e, Department d
	WHERE e.dept_id = d.dept_id

	SELECT e.emp_name, e.emp_salary, d.dept_name, d.dept_location
	FROM Employee e LEFT OUTER JOIN Department d
	ON e.dept_id = d.dept_id

	SELECT e.emp_name, e.emp_salary, d.dept_name, d.dept_location
	FROM Employee e RIGHT OUTER JOIN Department d
	ON e.dept_id = d.dept_id

	SELECT e.emp_name, e.emp_salary, d.dept_name, d.dept_location
	FROM Employee e FULL OUTER JOIN Department d
	ON e.dept_id = d.dept_id

-- Fetch Employee Name with their respective Manager Name:

	SELECT emp.emp_name, emp.emp_manager_id, mgr.emp_name, mgr.emp_id
	FROM Employee emp JOIN Employee mgr
	ON emp.emp_manager_id = mgr.emp_id
	OR emp.emp_manager_id IS NULL



	SELECT * FROM Employee;
	SELECT * FROM Department;

---------------------------------------------------------------------------





