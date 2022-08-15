INSERT INTO Employees (FirstName, LastName, Email, Password, ManagerID)
Values('Jane', 'Smith', 'JaneSmith1@Ourcompany.net', 12345, 1)

INSERT INTO Expenses (EmployeeIdFK, Date, Details, Amount, Approved)
Values(1, '8/1/22-8/3/22', 'Airline, hotel, meals, and rental car for conference', 934.97, 'Approved')
