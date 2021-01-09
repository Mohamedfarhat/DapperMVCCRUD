CREATE PROC EmployeeDeleteByID
@EmployeeID int
As
	DELETE FROM Employee
	WHERE EmployeeID=@EmployeeID