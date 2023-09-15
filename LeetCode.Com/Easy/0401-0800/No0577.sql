-- mysql
select 
	e.name,
	b.bonus
from No0577_Employee e
left join No0577_Bonus b
	on e.empId = b.empId
where IFNULL(b.bonus,0) < 1000;