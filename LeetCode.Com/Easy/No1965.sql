-- 1965.Employees With Missing Information
-- Write your MySQL query statement below

select t.employee_id
from
(
    select
    t1.employee_id
    from Employees t1
    where not exists(select t2.employee_id from Salaries t2 where t1.employee_id = t2.employee_id)

    union

    select
    t1.employee_id
    from Salaries t1
    where not exists(select t2.employee_id from Employees t2 where t1.employee_id = t2.employee_id)
) t
order by t.employee_id