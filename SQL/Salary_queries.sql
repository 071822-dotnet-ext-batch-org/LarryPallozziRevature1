SELECT *  -- test to see if querys works
FROM salary;


SELECT DISTINCT COUNT(EmployeeName)
FROM salary;


SELECT DISTINCT COUNT(JobTitle)
FROM salary;


SELECT MAX(TotalPay) AS Highest_salary, MIN(TotalPay) AS lowest_salary
FROM salary;


SELECT EmployeeName, OvertimePay, Department 
FROM salary
GROUP BY Department
LIMIT 5;


SELECT 
	SUM(CASE WHEN OvertimePay = 0 THEN 1 ELSE 0 END) AS No_OT,
	SUM(CASE WHEN OvertimePay > BasePay THEN 1 ELSE 0 END) AS High_OT
FROM salary;


SELECT COUNT(JobTitle)
FROM salary
WHERE JobTitle LIKE 'Chief_%';


SELECT COUNT(EmployeeName)
FROM (SELECT * FROM salary s WHERE Department = 'Other')
WHERE BasePay BETWEEN 100000 AND 200000;


SELECT Department, ROUND(AVG(BasePay), 2) AS Ave_Pay, ROUND(AVG(OvertimePay), 2) AS Ave_OT, ROUND(AVG(OtherPay), 2) AS Ave_other, ROUND(AVG(Benefits),2) AS Ave_benefits, ROUND(AVG(TotalPay), 2) AS Ave_totel_pay, ROUND(AVG(TotalPayBenefits), 2) AS Ave_total_pay_benefits
FROM salary
GROUP BY Department;

SELECT EmployeeName
FROM salary
WHERE EXISTS TotalPay = 0 AND 
