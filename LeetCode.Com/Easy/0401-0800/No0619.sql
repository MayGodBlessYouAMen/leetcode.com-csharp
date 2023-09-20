-- mysql
-- Biggest Single Number: 找出最大的只出现一次的数字
select 
max(t.num) num
from
(
	select 
	num
	from No0619_MyNumbers
	GROUP BY num
	having count(num) = 1
) t