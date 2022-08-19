-- Employee seed
INSERT INTO [dbo].[Employees] (EmployeeID, FirstName, LastName, IsManager, Email, Password)
VALUES('7b674e30-a6af-4895-bff8-fc7ef48a7591', 'Jane', 'Smith', 0, 'JSmith1@Ourco.com', '12345');

INSERT INTO [dbo].[Employees] (EmployeeID, FirstName, LastName, IsManager, Email, Password)
VALUES('1b674e11-a6af-4895-bff8-fc7ef48a7591', 'Abe', 'Brown', 0, 'ABrown1@Ourco.com', '12345');


-- Manager seed
INSERT INTO [dbo].[Employees] (EmployeeID, FirstName, LastName, IsManager, Email, Password)
VALUES('0dcb9f84-df04-49fd-9530-48ee4ba954ad', 'Allie', 'Ward', 1, 'AWard1@Ourco.com', '67890');
-- Request seed

INSERT INTO [dbo].[Request] (TicketID, FK_EmployeeId, Details, Amount, Status)
Values('c98f4ca3-fa0a-555e-aef6-6d5799249289', '1b674e11-a6af-4895-bff8-fc7ef48a7591',  '7/27 Hotel and meals for meeting', 130, 0);

INSERT INTO [dbo].[Request] (TicketID, FK_EmployeeId, Details, Amount, Status)
Values('97ef4dbe-c54a-451f-9064-21646863415d', '7b674e30-a6af-4895-bff8-fc7ef48a7591', '8/1/22-8/3/22 Airline, hotel, meals, and rental car for conference', 934.97, 1);

INSERT INTO [dbo].[Request] (TicketID, FK_EmployeeId, Details, Amount, Status)
Values('c77f4ca3-fa0a-444e-aef6-6d5799249289', '7b674e30-a6af-4895-bff8-fc7ef48a7591', '9/3/22 Business dinner', 237.87, 2);
