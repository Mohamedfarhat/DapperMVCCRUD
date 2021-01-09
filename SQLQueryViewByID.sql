CREATE PROC EmployeeViewByID
@EmployeeID int
As
	SELECT *
	FROM Employee
	WHERE EmployeeID=@EmployeeID