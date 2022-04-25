-- 1407 Top Travellers
-- Write your MySQL query statement below
select Users.name,
    ifnull(sum(Rides.distance),0) travelled_distance
from Users
 left join Rides on
 Users.id = Rides.user_id
 group by Users.name
 order by travelled_distance desc,Users.name