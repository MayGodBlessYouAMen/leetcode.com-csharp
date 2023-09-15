-- 1873.Calculate Special Bonus
-- Write your MySQL query statement below
-- 注意substring的index从1开始的
select 
employee_id ,
case when (employee_id%2<>0 and substring(name,1,1)<>'M')
then salary
else 0
end as bonus
from Employees
order by employee_id