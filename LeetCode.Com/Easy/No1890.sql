﻿-- 1890.The Latest Login in 2020
-- Write your MySQL query statement below
select user_id, max(time_stamp) last_stamp
from Logins
where YEAR(time_stamp) = 2020
group by user_id