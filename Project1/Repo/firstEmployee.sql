-- Example employee
INSERT INTO [dbo].[Employees] (FirstName, LastName, IsManager, Email, Password)
VALUES('Jane', 'Smith', 'No', 'JSmith1@Ourco.com', '12345');

-- Example employee expense ticket
INSERT INTO Expenses (EmployeeIdFK, Date, Details, Amount, Approved)
Values(1, '8/1/22-8/3/22', 'Airline, hotel, meals, and rental car for conference', 934.97, 'Approved');
