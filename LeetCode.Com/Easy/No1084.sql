﻿--1084. Sales Analysis III
--mysql
--解题思路：用having代替子查询
select p.product_id, p.product_name 
from Product p 
inner join Sales s on
p.product_id = s.product_id
group by p.product_id
having
min(s.sale_date)>='2019-01-01'
and
max(s.sale_date)<='2019-03-31'