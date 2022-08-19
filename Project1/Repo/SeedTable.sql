-- Create the basic employee table
CREATE TABLE Employees(
  EmployeeID UNIQUEIDENTIFIER PRIMARY KEY,
  FirstName NVARCHAR(25) NOT NULL,
  LastName NVARCHAR(25) NOT NULL,
  IsManager BIT NOT NULL,
  Email NVARCHAR(30) NOT NULL,
  Password NVARCHAR(25) NOT NULL);

-- Create the basic expense ticket table
  CREATE TABLE Request(
    TicketID UNIQUEIDENTIFIER PRIMARY KEY,
    FK_EmployeeId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Employees(EmployeeID) NOT NULL,
    Details NVARCHAR(MAX) NOT NULL,
    Amount MONEY NOT NULL,
    Status INT NOT NULL);
