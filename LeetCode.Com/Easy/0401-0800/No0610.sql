-- mysql
-- 判断x、y、z能否构成三角形: 任意两边之和大于第三边
select 
	x,
	y,
	z,
	(case 
		when 
			(x+y>z and x+z>y and y+z>x) 
		then
			'Yes'
		else
			'No'
	end) as triangle
from No0610_Triangle