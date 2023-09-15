--mysql
select c1.name as Customers 
from customers c1
where c1.id not in 
		(select o1.CustomerId 
			from orders as o1)