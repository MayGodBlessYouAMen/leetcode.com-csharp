--mysql
SELECT e1.Name as Employee 
FROM employee as e1 
	join employee as e2
	on e1.ManagerId = e2.Id
WHERE e1.Salary > e2.Salary