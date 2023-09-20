-- mysql
select 
	t1.name
from No0607_SalesPerson t1
where t1.sales_id not in(
	select 
	 t2.sales_id
	from No0607_Orders t2
	join No0607_Company t3 on 
		t2.com_id = t3.com_id 
		and
		t3.name = 'RED' 
)
