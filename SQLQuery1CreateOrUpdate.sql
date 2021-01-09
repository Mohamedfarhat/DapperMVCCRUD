CREATE PROC EmployeeAddOrEdit
@EmployeeID int,
@Name nvarchar(50),
@Position nvarchar(50),
@Age int,
@salary int
AS
	IF @EmployeeID=0
		INSERT INTO Employee(Name,Position,Age,Salary)
		VALUES(@Name,@Position,@Age,@Salary)
	ELSE
		UPDATE Employee
		SET

		Name=@Name,
		Position=@Position,
		Age=@Age,
		Salary=@Salary
		WHERE EmployeeID = @EmployeeID