-- mysql
select max(salary) as SecondHighestSalary 
from employee 
where salary < (select max(salary) as salary from employee);