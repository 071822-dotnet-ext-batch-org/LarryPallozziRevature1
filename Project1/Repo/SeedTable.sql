-- Create the basic employee table
CREATE TABLE Employees(
  EmployeeID INT PRIMARY KEY IDENTITY(1, 1),
  FirstName NVARCHAR(25) NOT NULL,
  LastName NVARCHAR(25) NOT NULL,
  IsManager NVARCHAR(3) NOT NULL,
  Email NVARCHAR(30) NOT NULL,
  Password NVARCHAR(25) NOT NULL);

-- Create the basic expense ticket table
  CREATE TABLE Expenses(
    TicketID INT PRIMARY KEY IDENTITY(1, 1),
    EmployeeIdFK INT FOREIGN KEY REFERENCES Employees(EmployeeID) NULL,
    Date NVARCHAR(25) NULL,
    Details NVARCHAR(100) NULL,
    Amount FLOAT NULL,
    Approved NVARCHAR(10) NULL);
