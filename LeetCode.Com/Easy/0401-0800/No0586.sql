-- mysql
select
	customer_number
from No0586_Orders
group by customer_number
order by count(*) desc
limit 1